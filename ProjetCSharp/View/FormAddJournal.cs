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
    public partial class FormAddJournal : Form
    {
        private List<User> allUsers, chosenUsers;
        private Session mySession;
        private FormAnimation formAnimation;
        public FormAddJournal(Session session)
        {
            InitializeComponent();
            mySession = session;
            FormBorderStyle = FormBorderStyle.None; //enlever la barre de titre.
            StartPosition = FormStartPosition.CenterScreen;

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            new FormDragEvent(this);
            formAnimation = new FormAnimation(this);
            new LabelMouseEvent(lbl_add);
            new LabelMouseEvent(lbl_remove);
            new LabelMouseEvent(lbl_exit);

            //preparer UI
            InitializeUI();
        }

        public void InitializeUI()
        {
            lbl_ID.Text = "ID: " + IdGenerator.generateID();
            lbl_date.Text = "Date: " + DateTime.Today.ToShortDateString();
            lbl_current_user.Text = "-- " + mySession.CurrentUser.Email + " (utilisateur présent)";
            txtbox_journal_name.Text = "";
            allUsers = new List<User>(Program.db.UserDB.Users.Count);
            chosenUsers = new List<User>(Program.db.UserDB.Users.Count);
            checkedListBox_all_users.Items.Clear();
            checkedListBox_chosen_users.Items.Clear();
            foreach (User usr in Program.db.UserDB.Users)
            {
                if (usr != mySession.CurrentUser)
                {
                    allUsers.Add(usr);
                    checkedListBox_all_users.Items.Add(usr.toString());
                }
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            /* Lorsqu'on déplace les utilisateurs entre deux listboxs, on met à jour également les deux tableux 'allUsers' et 'chosenUsers'
             * qui retient les références d'utilisateur(avec un type User) dans DB. Pour qu'on n'ai pas besoin de refaire une requête dans 
             * l'étape de la sauvegarde. (on sauvegarde directement les membres dans 'chosenUser').
             * D'ailleurs, on choisit une façon de requête basée sur l'indice, mais pas sur le nom, c'est pour qu'on ait une meilleure 
             * performance pendant la requête.
             */
            List<int> tmp = new List<int>(checkedListBox_all_users.CheckedItems.Count);
            foreach (int index in checkedListBox_all_users.CheckedIndices)
            {
                //Ajouter les éléments choisis dans l'autre listbox
                chosenUsers.Add(allUsers[index]);
                checkedListBox_chosen_users.Items.Add(checkedListBox_all_users.Items[index]);
                tmp.Add(index);
            }

            /* ici, on applique une boucle for inverse, puisque l'indice change tous le temps:
             * après avoir supprimé un élément du tableau, les indices des éléments suivants vont changé
             * si on fait la suppression de la fin au début, il aura pas ce problème.
             */
            int indx;
            for (int i = (tmp.Count - 1); i >= 0; i--)
            {
                //Supprimer les éléments choisis dans ce listbox
                indx = tmp[i];
                allUsers.RemoveAt(indx);
                checkedListBox_all_users.Items.RemoveAt(indx);
            }
            clearCheckedState();
        }

        private void lbl_remove_Click(object sender, EventArgs e)
        {
            //Explication s'écrit dans la methode 'lbl_add_Click'.
            List<int> tmp = new List<int>(checkedListBox_chosen_users.CheckedItems.Count);
            foreach (int index in checkedListBox_chosen_users.CheckedIndices)
            {
                allUsers.Add(chosenUsers[index]);
                checkedListBox_all_users.Items.Add(checkedListBox_chosen_users.Items[index]);
                tmp.Add(index);
            }

            int indx;
            for (int i = (tmp.Count - 1); i >= 0; i--)
            {
                indx = tmp[i];
                chosenUsers.RemoveAt(indx);
                checkedListBox_chosen_users.Items.RemoveAt(indx);
            }
            clearCheckedState();
        }

        private void clearCheckedState()
        {
            for (int i = 0; i < checkedListBox_all_users.Items.Count; i++)
                checkedListBox_all_users.SetItemChecked(i, false);

            for (int i = 0; i < checkedListBox_chosen_users.Items.Count; i++)
                checkedListBox_chosen_users.SetItemChecked(i, false);
        }




        //Verification et ajout du nouveau journal.
        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool journalNotExist = !Program.db.JournalDB.find(txtbox_journal_name.Text);
            if (txtbox_journal_name.Text != "" && chosenUsers.Count > 0 && journalNotExist)
            {
                chosenUsers.Add(mySession.CurrentUser);
                Journal newJournal = new Journal(txtbox_journal_name.Text, DateTime.Now);
                foreach (User usr in chosenUsers)
                    newJournal.ParticipantDB.add(usr);
                Program.db.JournalDB.Journals.Add(newJournal);
                Program.db.Users_journals.add(mySession.CurrentUser, newJournal); //mettre à jour la relation.
                InitializeUI();
                MessageBox.Show("Nouveau journal est bien ajouté.", "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                FormShakeEvent.shake(this);
                if (txtbox_journal_name.Text == "")
                    MessageBox.Show("Nom du journal indispensable.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!journalNotExist)
                    MessageBox.Show("Nom du journal exist déja.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (chosenUsers.Count <= 0)
                    MessageBox.Show("Il faut au moins un participant pour un journal.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
