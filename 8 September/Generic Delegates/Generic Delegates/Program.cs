using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Action<string> s = print;
            s("lkn");
            Predicate<string> p = Pcheck;
            Console.WriteLine(p("hvhj"));

        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }

        public static bool Pcheck(string str)
        {
            return str.Equals(str.ToUpper());

        }
    }
}
