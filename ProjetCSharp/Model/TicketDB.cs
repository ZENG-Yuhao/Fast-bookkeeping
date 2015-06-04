using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class TicketDB
    {
        private List<Ticket> tickets;

        public TicketDB()
        {
            this.tickets = new List<Ticket>();
        }

        public List<Ticket> Tickets
        {
            get { return tickets; }
        }

        public void add(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public Ticket get(string id)
        {
            Ticket returnValue = null;
            foreach (Ticket tkt in tickets)
            {
                if (tkt.TicketID == id)
                    returnValue = tkt;
            }
            return returnValue;
        }

        public void remove(string id)
        {
            foreach (Ticket tkt in tickets)
            {
                if (tkt.TicketID == id)
                    tickets.Remove(tkt);
            }
        }

        public void remove(Ticket ticket)
        {
            tickets.Remove(ticket);
        }
    }//class TicketDB
}
