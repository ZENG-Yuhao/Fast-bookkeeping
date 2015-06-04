using ProjetCSharp.Controller;
using ProjetCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCSharp.OCREngine;

namespace ProjetCSharp.View
{
    //Cette classe est une class dont la logique est un peu compliquée, car elle combine deux mode d'affichage (ADD et MODIFY)
    public partial class FormTicket : Form
    {
        private Session mySession;
        private int mode;
        private Ticket currentTicket;
        private Relationships<Article, User> relationship_Article_Payors; //qui doit, doivent payer cette article.
        private const int artLength = 40;

        //Dans le code, lorsqu'on met la statue 'checked' pour les éléments dans checkedlistbox, ça va invoker aussi la méthode itemCheck(), pour que ça n'empêche pas la logique, on cré deux 'lock'
        private bool payors_itemCheck_lock;

        public FormTicket(Session session, int mode)
        {
            this.InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.mySession = session;
            this.mode = mode;
            this.payors_itemCheck_lock = false;
            this.Initialize();

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            new FormDragEvent(this);
            new FormAnimation(this);
            new LabelMouseEvent(lbl_submit);
            new LabelMouseEvent(lbl_exit);
        }


        private void Initialize()
        {
            //IHM d'ajout et IHM de modification du ticket partagent un seul form, du coup il faut une marque pour séparer les deux.
            relationship_Article_Payors = new Relationships<Article, User>();
            if (mode == FormTicketMode.ADD)
            {
                txtbox_ticketName.Clear();
                txtbox_path.Clear();
                pictureBox1.Image = null;
                chckLBox_articles.Items.Clear();
                chchLBox_payors.Items.Clear();
                dateTimePicker1.Value = DateTime.Today;
                //Créer une copie bruilon, elle se change selon les opérations d'utilisateurs, elle va être enregistrée à la fin
                currentTicket = new Ticket();
                currentTicket.Owner = mySession.CurrentUser;

            } else if (mode == FormTicketMode.MODIFY)
            {
                btn_openFile.Visible = false;

                //charger les données
                string fileName = mySession.CurrentTicket.ImgPath;
                StreamReader reader = new StreamReader(fileName);
                pictureBox1.Image = Image.FromFile(fileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtbox_path.Text = fileName;
                reader.Close();

                currentTicket = mySession.CurrentTicket;
                dateTimePicker1.Value = currentTicket.Date;
                txtbox_ticketName.Text = currentTicket.Name;
                chckLBox_articles_prepare();
            }
            checkbox_modify.Checked = false;

        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            // clear articles
            chckLBox_articles.Items.Clear();
            currentTicket.Articles.Clear();

            // open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c://";
            openFileDialog.Filter = "Photo du ticket(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            // once a file is chosen
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name
                string fileName = openFileDialog.FileName;

                // load image
                StreamReader reader = new StreamReader(fileName);

                // show image
                pictureBox1.Image = Image.FromFile(fileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                // show file path
                txtbox_path.Text = fileName;

                // end loading
                reader.Close();

                // run OCR
                string OcrResult = OCR.RunOCR(fileName);

                // set current ticket data
                currentTicket.ImgPath = fileName;

                // get goods from ticket
                currentTicket.getArticlesFromString(OcrResult);

                // show goods
                chckLBox_articles_prepare();
            }
        }



        /* Lorsque l'article selectionnée change, il y quelques étape:
         * 1.Nettoyer checkedListBox_article_owner.
         * 2.Trouver l'article(élément du chekcedBox) qu'on a selectionnée, et charger checkedListBox_article_owner.
         */
        private void chckLBox_articles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Trouver l'indice du élément que l'utilisateur a choisi.
            int selectedIndex = chckLBox_articles.SelectedIndex;
            if (selectedIndex < 0 || currentTicket == null) return;

            //En fonction de l'indice obtenue, on retrouve l'article correspondante dans bufferTicket.
            Article artCorresponded = currentTicket.Articles[selectedIndex];
            txtbox_modify_content.Text = artCorresponded.Content;
            txtbox_modify_price.Text = artCorresponded.Price;

            chckLBox_payors_prepare();
        }

        private void chckLBox_articles_prepare()
        {
            chckLBox_articles.Items.Clear();
            //Ajouter les items dans checkedListBox
            int index = 0;
            foreach (Article art in currentTicket.Articles)
            {
                chckLBox_articles.Items.Add(art.toString(artLength));
                chckLBox_articles.SetItemChecked(index, true);
                index++;

                /* Initialiser la relation (les payants de l'article)
                 * Si le nombre de payants pour l'article est 0, on prend tous les membres du journal comme les payants.
                 * Sinon, on initialise la relation par rapport à la liste des payants.
                 * En fonction de deux conditions ci-dessus, on décide quelle liste de users(source) qu'on choisira
                 */
                List<User> source;
                if (art.Participants.Count == 0)
                    source = mySession.CurrentJournal.ParticipantDB.Users;
                else
                    source = art.Participants;

                foreach (User usr in source)
                    relationship_Article_Payors.add(art, usr);
            }
        }

        private void chckLBox_payors_prepare()
        {
            int selectedIndex = chckLBox_articles.SelectedIndex;
            //Retrouver les utilisateurs selectionnés par rapport à l'indice du élément.
            List<User> usersChecked = relationship_Article_Payors[selectedIndex];

            //Ajouter les items dans checkedListBox_payors
            chchLBox_payors.Items.Clear();
            chchLBox_payors.BeginUpdate();
            int i = 0;
            payors_itemCheck_lock = true;
            foreach (User usr in mySession.CurrentJournal.ParticipantDB.Users)
            {
                chchLBox_payors.Items.Add(usr.toString());
                if (usersChecked.Contains(usr)) chchLBox_payors.SetItemChecked(i, true);
                else chchLBox_payors.SetItemChecked(i, false);
                i++;
            }
            payors_itemCheck_lock = false;
            chchLBox_payors.EndUpdate();
        }


        private void chckLBox_payors_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (!payors_itemCheck_lock && e.Index >= 0)
            {
                int selectedArticleIndex = chckLBox_articles.SelectedIndex;
                bool isChecked = (e.NewValue == CheckState.Checked);

                Article articleSelected = currentTicket.Articles[selectedArticleIndex];
                User userSelected = mySession.CurrentJournal.ParticipantDB.Users[e.Index];

                //si un membre journal est coché, on l'ajoute dans la liste des payants, sinon on le supprime.
                if (isChecked)
                    relationship_Article_Payors.add(articleSelected, userSelected);
                else
                    relationship_Article_Payors.remove(articleSelected, userSelected);
            }

        }


        private void checkbox_modify_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkbox_modify.Checked)
            {
                txtbox_modify_content.ReadOnly = false;
                txtbox_modify_price.ReadOnly = false;
                txtbox_modify_content.BackColor = Color.White;
                txtbox_modify_price.BackColor = Color.White;
            } else
            {
                int selectedIndex = chckLBox_articles.SelectedIndex;
                //l'état de checkbox devient blocké
                txtbox_modify_content.ReadOnly = true;
                txtbox_modify_price.ReadOnly = true;
                txtbox_modify_content.BackColor = Color.Orange;
                txtbox_modify_price.BackColor = Color.Orange;

                //si on a choisi aucune article, on quitte directement.
                if (selectedIndex < 0)
                {
                    txtbox_modify_content.Clear();
                    txtbox_modify_price.Clear();
                    return;
                }

                //verifier le format du prix
                if (Formatter.NumberCheck(txtbox_modify_price.Text))
                {
                    //Sauvegarder le changement du l'article dans bufferTicket et mettre à jour le contenu du checkedListBox
                    Article selectedArticle = currentTicket.Articles[selectedIndex];
                    selectedArticle.Content = txtbox_modify_content.Text;
                    selectedArticle.Price = txtbox_modify_price.Text;
                    chckLBox_articles.Items[selectedIndex] = selectedArticle.toString(40);

                } else
                {
                    checkbox_modify.CheckState = CheckState.Checked;
                    FormShakeEvent.shake(this);
                    string errorMsg = "Votre prix d'article est incorrect: " + txtbox_modify_price;
                    MessageBox.Show(errorMsg, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void checkbox_add_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkbox_add.Checked)
            {
                txtbox_add_content.Clear();
                txtbox_add_price.Clear();
                txtbox_add_content.Visible = true;
                txtbox_add_price.Visible = true;
                btn_verify_add.Visible = true;

            } else
            {
                txtbox_add_content.Clear();
                txtbox_add_price.Clear();
                txtbox_add_content.Visible = false;
                txtbox_add_price.Visible = false;
                btn_verify_add.Visible = false;
            }
        }

        private void lbl_submit_Click(object sender, EventArgs e)
        {
            if (!validate()) return;


            //mise à jour du currentTiket,de la date et supprimer les articiles non sélectionnées
            currentTicket.Name = txtbox_ticketName.Text.Trim();
            currentTicket.Date = dateTimePicker1.Value;
            for (int index = (currentTicket.Articles.Count - 1); index >= 0; index--)
            {
                Article art = currentTicket.Articles[index];
                bool isChecked = chckLBox_articles.CheckedIndices.Contains(index);
                if (!isChecked)
                {
                    currentTicket.Articles.RemoveAt(index);
                }
            }

            currentTicket.caculateTotalAmount();


            //mise à jour des payants pour chaque article dans la copie du ticket
            foreach (Article art in currentTicket.Articles)
            {
                art.Participants = relationship_Article_Payors.get(art);
            }


            User currentUser = mySession.CurrentUser;
            Journal currentJournal = mySession.CurrentJournal;
     

            if (mode == FormTicketMode.ADD)
            {
                //sauvegarder la copie du ticket et de la relation dans le journal du DB
                currentTicket.Owner = mySession.CurrentUser;
                currentJournal.TicketDB.Tickets.Add(currentTicket);
            } 
            //Nettoyer UI
            Initialize();

            MessageBox.Show("Changement est bien enregistré!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private bool validate()
        {
            bool ticketNameNotEmpty = txtbox_ticketName.Text != "";
            bool articleNotEmpty = chckLBox_articles.CheckedIndices.Count != 0;
            bool payorNotEmpty = true;
            foreach (KeyValuePair<Article, List<User>> kvp in relationship_Article_Payors)
            {
                if (kvp.Value.Count == 0)
                {
                    payorNotEmpty = false;
                    break;
                }
            }

            string errorMsg = "Message d'erreurs: \n";
            if (!ticketNameNotEmpty) errorMsg += "Nom du ticket indispensable. \n";
            if (!articleNotEmpty) errorMsg += "Il faut au mois une article pour un ticket. \n";
            if (!payorNotEmpty) errorMsg += "Il faut au mois un payor pour une article. \n";

            if (ticketNameNotEmpty && articleNotEmpty && payorNotEmpty)
                return true;
            else
            {
                FormShakeEvent.shake(this);
                MessageBox.Show(errorMsg, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_verify_add_Click(object sender, EventArgs e)
        {
            bool contentNotEmpty = txtbox_add_content.Text != "";
            bool priceNotEmpty = txtbox_add_price.Text != "";
            bool priceFormatRight = Formatter.NumberCheck(txtbox_add_price.Text);
            string errorMsg = "Message d'erreurs: \n";
            if (!contentNotEmpty) errorMsg += "Contenu de l'article est vide.\n";
            if (!priceNotEmpty) errorMsg += "Prix de l'article est vide.\n";
            if (!priceFormatRight) errorMsg += "Format du prix est incorrect.\n";
            if (contentNotEmpty && priceNotEmpty && priceFormatRight)
            {
                Article newArticle = new Article(txtbox_add_content.Text, txtbox_add_price.Text, currentTicket);
                foreach (User usr in mySession.CurrentJournal.ParticipantDB.Users)
                {
                    newArticle.Participants.Add(usr);
                }
                currentTicket.Articles.Add(newArticle);
                chckLBox_articles_prepare();
                checkbox_add.Checked = false;
                MessageBox.Show("Nouvelle article est bien enregistrée!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                FormShakeEvent.shake(this);
                MessageBox.Show(errorMsg, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
