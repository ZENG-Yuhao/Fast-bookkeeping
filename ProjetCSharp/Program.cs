using ProjetCSharp.Model;
using ProjetCSharp.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp
{

    static class Program
    {
        public static string pathDB;
        public static DataBase db;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool appIsNotRunning = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                out appIsNotRunning);

            //On admit qu'une seule application fonctionne, pour que ça cause pas des problèmes de synchronisation des données.
            if (!appIsNotRunning)
            {
                MessageBox.Show("Avertissement:", "L'application est en train de marcher.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormLogin frmLogin = new FormLogin();

                pathDB = "DataBase.bin";
                db = new DataBase();
                db = initializeDB(pathDB);
                Application.Run(frmLogin);

                //A la fin de l'execution d'application, on exporte DB dans le fichier, pour qu'on utilise la prochaine fois.
                DataBase.exportToSerializedFile(db, pathDB);
            }
        }

        static DataBase initializeDB(string path)
        {
            //S'il y a déja un fichier sauvegardé, on l'importe directement.
            //S'il y a pas de fichier sauvegardé, ça veut dire que c'est la première fois qu'on utilise cette application on cré une nouvelle DB.
            DataBase returnDB;
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                returnDB = DataBase.importFromSerializedFile(path);
            } else
            {
                returnDB = new DataBase();
            }
            return returnDB;
        }
    }
}
