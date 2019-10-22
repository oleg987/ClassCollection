using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class UserDB
    {
        string title;
        User[] users;
        User[] deletedUsers;

        public UserDB()
        {
            users = new User[0];
        }
        public UserDB(User[] users)
        {            
            Add(users);
        }

        public UserDB(User user)
        {
            Add(user);
        }

        public void Add(User user)
        {
            if (users == null || users.Length == 0)
            {
                users = new User[1];
                users[0] = user;
            }
            else
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = user;
            }
        }

        public void Add(User[] users)
        {
            if (this.users == null || this.users.Length == 0)
            {
                this.users = new User[users.Length];
                this.users = users;
            }
            else
            {
                int size = this.users.Length;
                Array.Resize(ref this.users, this.users.Length + users.Length);

                for (int i = 0; i < users.Length; i++)
                {
                    this.users[size + i] = users[i];
                }
            }
        }

        public User Find(string name)
        {
            foreach (User user in users)
            {
                if (user != null && user.FindByName(name))
                {
                    return user;
                }
            }
            return null;
        }

        public User[] FindAll(string name)
        {
            User[] users = new User[0];

            foreach (User user in this.users)
            {
                if (user != null && user.FindByName(name))
                {
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user;
                }
            }

            return users;
        }

        public override string ToString()
        {
            string result = "";

            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user != null)
                    {
                        result += user.ToString() + "\n";
                    }                    
                }
            }

            return result;
        }
    }
}
