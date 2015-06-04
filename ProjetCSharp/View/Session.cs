using ProjetCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.View
{
    public class Session
    {
        private User currentUser;
        private Journal currentJournal;
        private Ticket currentTicket;

        public Session()
        {
            this.currentUser = null;
            this.currentJournal = null;
            this.currentTicket = null;
        }

        public Session(User user)
        {
            this.currentUser = user;
            this.currentTicket = null;
            this.currentJournal = null;
        }

        public Session(User user, Journal journal, Ticket ticket)
        {
            this.currentUser = user;
            this.currentJournal = journal;
            this.currentTicket = ticket;
        }

        public User CurrentUser
        {
            set { currentUser = value; }
            get { return currentUser; }
        }

        public Journal CurrentJournal
        {
            get { return currentJournal; }
            set { currentJournal = value; }
        }

        public Ticket CurrentTicket
        {
            get { return currentTicket; }
            set { currentTicket = value; }
        }


    }
}
