using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonlydemo
{
    class User
    { 
        public readonly string name = "shardha";
        public readonly string location;
        public readonly int age;

        public User()
        {
            location = "lko";
            age = 23;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            User u = new User();
            Console.Write(u.name);
            Console.Write(u.location);
            Console.Write(u.age); 

        }
    }
}
