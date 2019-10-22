using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class User
    {
        public static int currentId = 1;

        int id;
        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public User(string name, int age)
        {
            id = currentId++;
            Name = name;
            Age = age;            
        }

        public bool FindByName(string name) // John == john
        {
            if (name != "" && this.name.ToLower().Contains(name.ToLower()))
            //if (name != "" && this.name.ToLower() == name.ToLower())
            {                
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, ID: {id}";
        }
    }
}
