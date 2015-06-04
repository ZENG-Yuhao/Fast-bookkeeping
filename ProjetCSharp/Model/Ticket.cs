using ProjetCSharp.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class Ticket : IComparable
    {
        private string ticketID;

        private string name;
        private List<Article> articles;
        private DateTime date;
        private string imgPath;
        private User owner; //l'utilisateur qui crée ce ticket, il y a qu'un seul.
        private float totalAmount;

        public Ticket()
        {
            this.ticketID = IdGenerator.generateID();
            this.articles = new List<Article>();
            this.totalAmount = 0.000f;
        }
        public User Owner
        {
            set { owner = value; }
            get { return owner; }
        }

        public string TicketID
        {
            get { return ticketID; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public List<Article> Articles
        {
            get { return articles; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }

        public string ImgPath
        {
            set { imgPath = value; }
            get { return imgPath; }
        }

        public float TotalAmount
        {
            set { totalAmount = value; }
            get { return totalAmount; }
        }

        //La méthode ci-dessous sert à tirer la libéllé et le prix pour chaque article dans un ticket.
        //ex:    POULLET ROTI x2   25.32  (une article)
        //         libéllé:  POULLET ROTI x2          prix: 25.32
        public void getArticles(string path)
        {
            StreamReader reader = new StreamReader(path);

            string pattern = "^(?<content>(\\S+\\s+)+)(?<price>\\d+([.]\\d+)?)$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches;
            GroupCollection groups;
            Article article;
            string line = reader.ReadLine();
            while (line != null)
            {
                matches = rgx.Matches(line);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        groups = match.Groups;
                        string content = groups["content"].Value.Trim();
                        string price = groups["price"].Value.Trim();
                        article = new Article(content, price, this);
                        articles.Add(article);
                    }
                }
                line = reader.ReadLine();
            }
        }

        public void getArticlesFromString(string OcrResult)
        {
            // replace all "," by "."
            OcrResult = OcrResult.Replace(",", ".");
            string[] lines = OcrResult.Split('\n');

            string pattern = "(^(?<content>(\\S+\\s+)+))((?<price>(\\d+)(\\s*)[.,](\\s*)(\\d)(\\s*)(\\d))(\\s+)((E|EUR)?)(\\s*)([ABab0-9]?)(\\s*))$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches;
            GroupCollection groups;
            Article article;
            foreach (string line in lines)
            {
                Console.Write(line);
                matches = rgx.Matches(line);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        groups = match.Groups;
                        string content = groups["content"].Value.Trim();
                        string price = Regex.Replace(groups["price"].Value, @"\s", "");
                        article = new Article(content, price, this);
                        articles.Add(article);
                    }
                }
            }
        }

        public float caculateTotalAmount()
        {
            float total = 0.000f;
            foreach (Article art in Articles)
                total += float.Parse(art.Price);
            this.totalAmount = total;
            return total;
        }

        public override string ToString()
        {
            string returnValue = "";
            int i = 0;
            foreach (Article art in articles)
            {
                i++;
                returnValue += art.toString(50) + "\n";
            }
            return returnValue;
        }

        public int CompareTo(object obj)
        {
            Ticket tck = (Ticket)obj;
            if (date >= tck.date)
                return -1;
            else
                return 1;

        }
    }//class Ticket
}
