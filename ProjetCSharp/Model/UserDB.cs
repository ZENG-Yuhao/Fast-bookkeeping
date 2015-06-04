using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class UserDB
    {
        private List<User> users;
        public List<User> Users
        {
            get { return users; }
        }

        public UserDB()
        {
            this.users = new List<User>();
        }

        public void add(User user)
        {
            users.Add(user);
        }

        public bool find(User user)
        {
            return users.Contains(user);
        }

        public bool find(string email)
        {
            bool found = false;
            foreach (User usr in users)
            {
                if (usr.Email == email)
                    found = true;
            }
            return found;
        }

        public User get(string email)
        {
            User returnValue = null;
            foreach (User usr in users)
            {
                if (usr.Email == email)
                    returnValue = usr;
            }
            return returnValue;
        }

        public void remove(string email)
        {
            foreach (User usr in users)
            {
                if (usr.Email == email)
                    users.Remove(usr);
            }
        }

        public void remove(User user)
        {
            users.Remove(user);
        }
    }
}
