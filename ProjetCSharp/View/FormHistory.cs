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
    public partial class FormHistory : Form
    {
        private Session mySession;
        private FormAnimation formAnimation;
        public FormHistory(Session session)
        {
            InitializeComponent();
            mySession = session;
            InitializeListBox();
            FormBorderStyle = FormBorderStyle.None; //enlever la barre de titre.
            StartPosition = FormStartPosition.CenterScreen;

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            new FormDragEvent(this);
            new LabelMouseEvent(lbl_exit);
            formAnimation = new FormAnimation(this);
        }

        private void InitializeListBox()
        {
            listBox_participants.Items.Clear();
            listBox_journals.Items.Clear();
            foreach (Journal jrnl in Program.db.JournalDB.Journals)
                if (jrnl.ParticipantDB.find(mySession.CurrentUser))
                    listBox_journals.Items.Add(jrnl.JName);

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void listBox_journals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_journals.SelectedIndex;
            if (selectedIndex > -1)
            {
                Journal jrnlSelected = Program.db.JournalDB.Journals[selectedIndex];
                listBox_participants.Items.Clear();
                foreach (User usr in jrnlSelected.ParticipantDB.Users)
                    listBox_participants.Items.Add(usr.toString());
                listBox_participants.Items.Add("Nomber of Tickets: " + jrnlSelected.TicketDB.Tickets.Count);
            }
        }

        private void listBox_journals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox_journals.IndexFromPoint(e.Location);
            if (selectedIndex != System.Windows.Forms.ListBox.NoMatches)
            {
                Journal jrnlSelected = Program.db.JournalDB.Journals[selectedIndex];
                mySession.CurrentJournal = jrnlSelected;
                FormListTickets frmListTicket = new FormListTickets(mySession);
                formAnimation.Hide();
                frmListTicket.Owner = this;
                frmListTicket.ShowDialog();
                InitializeListBox();
                formAnimation.Show();
                mySession.CurrentJournal = null; //Après avoir fermé la fenêtre, il faut supprimer le journal dans la session

            }

        }
    }
}
