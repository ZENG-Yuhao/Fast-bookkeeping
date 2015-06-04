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
    public partial class FormBalance : Form
    {
        private Session mySession;
        private FormAnimation formAnimation;
        private Dictionary<User, double[]> balance;
        public FormBalance(Session session)
        {
            InitializeComponent();
            balance = new Dictionary<User, double[]>();
            StartPosition = FormStartPosition.CenterScreen;
            this.mySession = session;
            caculateBalance();
            InitializeListViewBox();

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            formAnimation = new FormAnimation(this);
            new FormDragEvent(this);
            new LabelMouseEvent(lbl_exit);
        }

        public void InitializeListViewBox()
        {
            //Nettoyer
            listView_balance.Clear();

            //Configuration
            listView_balance.View = System.Windows.Forms.View.Details;
            listView_balance.Scrollable = true;
            listView_balance.LabelWrap = true;
            //listView_balance.GridLines = true;
            listView_balance.FullRowSelect = true;

            //Créer les colones pour listView.
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Width = 250; //auto
            colHead.Text = "Nom (Compte)";
            listView_balance.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 200; //auto
            colHead.TextAlign = HorizontalAlignment.Center;
            colHead.Text = "Montant payé";
            listView_balance.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 200;
            colHead.TextAlign = HorizontalAlignment.Center;
            colHead.Text = "Montant consommé";
            listView_balance.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 200;
            colHead.TextAlign = HorizontalAlignment.Center;
            colHead.Text = "Solde";
            listView_balance.Columns.Add(colHead);

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            listView_balance.BeginUpdate();
            foreach (User usr in mySession.CurrentJournal.ParticipantDB.Users) {
                lvi = new ListViewItem();
                lvi.Text = usr.LastName + " " + usr.FirstName + " (" + usr.Email + ")";

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = String.Format("{0:N}",balance[usr][0]);
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = String.Format("{0:N}", balance[usr][1]);
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = String.Format("{0:N}", balance[usr][2]);
                lvi.SubItems.Add(lvsi);

                listView_balance.Items.Add(lvi);

            }
            listView_balance.EndUpdate();
        }

        private void caculateBalance()
        {
            balance.Clear();
            foreach (User usr in mySession.CurrentJournal.ParticipantDB.Users)
            {
                double[] info = new double[3];
                balance.Add(usr, info);
            }

            double[] getInfo;
            foreach (Ticket tck in mySession.CurrentJournal.TicketDB.Tickets)
            {
                getInfo = balance[tck.Owner];
                getInfo[0] += tck.TotalAmount;  //montant payé
                foreach (Article art in tck.Articles)
                {
                    foreach (User usr in art.Participants)
                    {
                        getInfo = balance[usr];
                        getInfo[1] += Double.Parse(art.Price) / art.Participants.Count; ;//montant consommé
                    }
                }
            }//end foreach tck

            foreach (User usr in mySession.CurrentJournal.ParticipantDB.Users)
            {
                getInfo = balance[usr];
                getInfo[2] = getInfo[0] - getInfo[1];
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//end class
}
