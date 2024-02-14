using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class User
    {
        // Initialize Read Only Fields
        public readonly string name;
        public readonly string location;
        public readonly int age;
        public User(string ism, string manzil, int yosh)
        {
            name = ism;
            location = manzil;
            age = yosh; 
        }
    }
}
