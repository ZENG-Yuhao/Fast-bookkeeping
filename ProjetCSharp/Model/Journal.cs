using ProjetCSharp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class Journal
    {
        private string journalID;
        private string jName;
        private DateTime date;
        private UserDB participantDB; //participants du journal
        private TicketDB ticketDB;

        public Journal(string jName, DateTime date)
        {
            this.journalID = IdGenerator.generateID();
            this.jName = jName;
            this.date = date;
            this.participantDB = new UserDB();
            this.ticketDB = new TicketDB();
        }

        public string JournalID
        {
            get { return journalID; }
        }

        public string JName
        {
            set { jName = value; }
            get { return jName; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return Date; }
        }

        public UserDB ParticipantDB
        {
            get { return participantDB; }
        }

        public TicketDB TicketDB
        {
            get { return ticketDB; }
        }


    }
}
