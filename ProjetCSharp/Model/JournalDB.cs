using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class JournalDB
    {
        private List<Journal> journals;

        public JournalDB()
        {
            this.journals = new List<Journal>();
        }

        public List<Journal> Journals
        {
            get { return journals; }
        }

        public void add(Journal journal)
        {
            journals.Add(journal);
        }

        public void remove(Journal journal)
        {
            foreach (Journal j in journals)
            {
                if (j == journal)
                    journals.Remove(j);
            }
        }

        public Journal get(string journalName)
        {
            foreach (Journal jrnl in journals)
            {
                if (jrnl.JName == journalName)
                {
                    return jrnl;
                }
            }
            return null;
        }
        public bool find(string journalName)
        {
            bool found = false;
            foreach (Journal jrnl in journals)
            {
                if (jrnl.JName == journalName)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
    }
}
