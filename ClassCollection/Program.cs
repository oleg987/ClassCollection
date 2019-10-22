using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Panama", 19);
            User user1 = new User("Alice", 26);
            User user2 = new User("Ann", 17);
            User user3 = new User("Alice", 15);
            User user4 = new User("Antony", 45);

            User[] users = new User[4];
            users[0] = user;
            users[1] = user1;
            users[2] = user2;
            users[3] = user1;

            UserDB userDB = new UserDB(users);

            //Console.WriteLine(userDB);

            //UserDB DB = new UserDB(user);
            //Console.WriteLine(DB);

            //UserDB userDB1 = new UserDB();

            userDB.Add(users);
            userDB.Add(user);
            userDB.Add(user3);
            userDB.Add(user4);
            //Console.WriteLine(userDB);


            foreach (User item in userDB.FindAll("AN"))
            {
                Console.WriteLine(item);
            }

            string name = "";
            name.
        }
    }
}
