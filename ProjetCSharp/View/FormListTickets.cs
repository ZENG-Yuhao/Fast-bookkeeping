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
    public partial class FormListTickets : Form
    {
        private Session mySession;
        private FormAnimation formAnimation;
        public FormListTickets(Session session)
        {
            InitializeComponent();
            mySession = session;
            InitializeListView();
            StartPosition = FormStartPosition.CenterScreen;

            //ajouter les nouvelles surveillances des événements de cette fenêtre 
            formAnimation = new FormAnimation(this);
            new FormDragEvent(this);
            new LabelMouseEvent(lbl_addTicket);
            new LabelMouseEvent(lbl_balance);
            new LabelMouseEvent(lbl_exit);
        }

        private void InitializeListView(){
            //Nettoyer
            listView_tickets.Clear();

            //Configuration
            listView_tickets.View = System.Windows.Forms.View.Details;
            listView_tickets.Scrollable = true;
            listView_tickets.LabelWrap = true;
            //listView_tickets.GridLines = true;
            listView_tickets.FullRowSelect = true;

            //Créer les colones pour listView.
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Width = 150; //auto
            colHead.Text = "Nom du ticket";
            listView_tickets.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 150; //auto
            colHead.TextAlign = HorizontalAlignment.Center;
            colHead.Text = "Date de création";
            listView_tickets.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 150;
            colHead.TextAlign = HorizontalAlignment.Center;
            colHead.Text = "Montant(Euro)";
            listView_tickets.Columns.Add(colHead);


            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            mySession.CurrentJournal.TicketDB.Tickets.Sort();
            listView_tickets.BeginUpdate();
            foreach(Ticket tck in mySession.CurrentJournal.TicketDB.Tickets){
                lvi = new ListViewItem();
                lvi.Text = tck.Name;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = tck.Date.ToShortDateString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = tck.TotalAmount.ToString();
                lvi.SubItems.Add(lvsi);

                listView_tickets.Items.Add(lvi);
            }
            listView_tickets.EndUpdate();
        }

        private void lbl_addTicket_Click(object sender, EventArgs e)
        {
            FormTicket frmTicket = new FormTicket(mySession, FormTicketMode.ADD);
            formAnimation.Hide();
            frmTicket.Owner = this;
            frmTicket.ShowDialog();
            InitializeListView();
            formAnimation.Show();

        }

        private void listView_tickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index_selectedItem = listView_tickets.SelectedIndices[0];
            if (index_selectedItem == -1) return;

            Ticket selectedTicket = mySession.CurrentJournal.TicketDB.Tickets[index_selectedItem];

            mySession.CurrentTicket = selectedTicket;
            FormTicket frmTicket = new FormTicket(mySession, FormTicketMode.MODIFY);
            formAnimation.Hide();
            frmTicket.Owner = this;
            frmTicket.ShowDialog();
            InitializeListView();
            formAnimation.Show();
            mySession.CurrentTicket = null;
        }

        private void lbl_balance_Click(object sender, EventArgs e)
        {
            FormBalance frmBalance = new FormBalance(mySession);
            formAnimation.Hide();
            frmBalance.ShowDialog();
            formAnimation.Show();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
