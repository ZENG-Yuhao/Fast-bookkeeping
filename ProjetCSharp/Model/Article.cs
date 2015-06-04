using ProjetCSharp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class Article
    {
        private string articleID;
        private string content;
        private string price;
        private Ticket father; //auquel ticket appartient cette article
        private List<User> participants;

        public Article(string content, string price, Ticket father)
        {
            this.articleID = IdGenerator.generateID();
            this.content = content;
            this.price = price;
            this.father = father;
            this.participants = new List<User>();
        }

        public string ArticleID
        {
            get { return articleID; }
        }

        public string Content
        {
            set { content = value; }
            get { return content; }
        }

        public string Price
        {
            set { price = value; }
            get { return price; }
        }

        public Ticket Father
        {
            set { father = value; }
            get { return father; }
        }

        public List<User> Participants
        {
            set { participants = value; }
            get { return participants; }
        }

        //cette méthode permet de formaliser les informations de l'article avec un bon alignement et une longueur indiquée.
        public string toString(int length)
        {
            if (length > 5)
            {
                string format1 = "{0,-" + (length - 5) + "}";
                string format2 = "{0, 5}";
                return (String.Format(format1, content) + String.Format(format2, price));
                //return content.PadRight(length - 5, '　') + price.PadLeft(5, '　');
            } else
                return content + price;
        }
    }
}
