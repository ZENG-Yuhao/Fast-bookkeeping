using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

//Dans notre cas, on aura pas besoin d'une vraie base de données, parce que l'application fonctionne localement-
//et les utilisateurs sont très limités, il y aura pas beaucoup de données
//L'idée appliquée ici, c'est qu'on utilise les classes pour simuler une base de données, à l'aide de la technologie serialisation, 
//on peut serialiser les classes en flut bit, et puis les sauvegarder dans le disque dur.
namespace ProjetCSharp.Model
{
    [Serializable]
    public class DataBase
    {
        //ici, UserDB est différent que celui dans Journal, le UserDB ici enregistre tous les utilisateurs inscrits pour cette application.
        //celui dans Journal retient seulement les participants du journal.
        private UserDB userDB;
        private JournalDB journalDB;
        private Relationships<User, Journal> users_journals;

        public DataBase()
        {
            this.userDB = new UserDB();
            this.journalDB = new JournalDB();
            this.users_journals = new Relationships<User, Journal>();
            User user;
            user = new User("admin", "administrator", "", "123");
            userDB.add(user);
            user = new User("zengyuhao@esigelec.fr", "ZENG", "Yuhao", "123");
            userDB .add(user);
            user = new User("jiyuan@esigelec.fr", "JI", "Yuan", "123");
            userDB.add(user);
            user = new User("gaowenfeng@esigelec.fr", "GAO", "Wenfeng", "123");
            userDB.add(user);
            user = new User("tangyuhuang@esigelec.fr", "TANG", "Yuhuang", "123");
            userDB.add(user);
            user = new User("huangmincong@esigelec.fr", "HUANG", "Mincong", "123");
            userDB.add(user);
        }

        public UserDB UserDB
        {
            get { return userDB; }
        }

        public JournalDB JournalDB
        {
            get { return journalDB; }
        }

        public Relationships<User, Journal> Users_journals
        {
            get { return users_journals; }
        }

        public static DataBase importFromSerializedFile(string path)
        {
            IFormatter serializer = new BinaryFormatter();
            FileStream loadFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataBase returnDB = serializer.Deserialize(loadFile) as DataBase;
            loadFile.Close();
            return returnDB;
        }

        public static void exportToSerializedFile(DataBase db, string path)
        {
            IFormatter serializer = new BinaryFormatter();
            FileStream saveFile = new FileStream(path, FileMode.Create, FileAccess.Write);
            serializer.Serialize(saveFile, db);
            saveFile.Close();
        }
    }
}
