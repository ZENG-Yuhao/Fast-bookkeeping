using ProjetCSharp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class User
    {
        private string userID;
        private string firstName;
        private string lastName;
        private string email;// On l'utilise comme un compte pour se connecter, une fois qu'il est cré, il ne peut pas être changé.
        private string password;
        private bool hasNewMessage;
        private List<string> messages;

        public User()
        {
            this.userID = IdGenerator.generateID();
        }

        public User(string email, string lastName, string firstName, string password)
        {
            this.email = email;
            this.lastName = lastName;
            this.firstName = firstName;
            this.password = password;
            this.userID = IdGenerator.generateID();
            hasNewMessage = false;
            messages = new List<string>();
        }

        public string Email
        {
            get { return email; }
        }

        public string UserID
        {
            get { return userID; }
        }

        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public bool HasNewMessage
        {
            get { return hasNewMessage; }
            set { hasNewMessage = value; }
        }

        public List<string> Messages
        {
            get { return messages; }
        }

        public void addMessage(string msg)
        {
            messages.Add(msg);
        }

        public void removeMessage()
        {
            if (messages.Count > 0)
                messages.RemoveAt(messages.Count - 1);
        }

        public void removeAllMessages()
        {
            messages.Clear();
        }

        public int numberMessages()
        {
            return messages.Count;
        }

        public string toString()
        {
            return email + "   (" + lastName + " " + firstName + ")";
        }


    }
}
