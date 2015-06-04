using ProjetCSharp.Controller;
using ProjetCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.View
{
    public partial class FormUser : Form
    {
        private Session mySession;
        private FormAnimation formAnimation;

        public FormUser(Session session)
        {
            InitializeComponent();
            mySession = session;
            lbl_user_name.Text = "Hi, " + mySession.CurrentUser.LastName + " " + mySession.CurrentUser.FirstName;



            //configuration du Form
            FormBorderStyle = FormBorderStyle.None; //enlever la barre de titre.
            StartPosition = FormStartPosition.CenterScreen;

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            formAnimation = new FormAnimation(this);
            new FormDragEvent(this);
            new LabelMouseEvent(lbl_user_name);
            new LabelMouseEvent(lbl_new_journal);
            new LabelMouseEvent(lbl_history);
            new LabelMouseEvent(lbl_logout);
            new LabelMouseEvent(lbl_exit);
        }

        private void lbl_new_journal_Click(object sender, EventArgs e)
        {
            FormAddJournal frmAddJournal = new FormAddJournal(mySession);
            formAnimation.Hide();
            frmAddJournal.Owner = this;
            frmAddJournal.ShowDialog();
            formAnimation.Show();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            DataBase.exportToSerializedFile(Program.db, Program.pathDB);
            Environment.Exit(0);
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_history_Click(object sender, EventArgs e)
        {
            FormHistory frmHistory = new FormHistory(mySession);
            formAnimation.Hide();
            frmHistory.Owner = this;
            frmHistory.ShowDialog();
            formAnimation.Show();
        }

    }
}
