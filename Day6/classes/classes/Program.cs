using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
     { 
        public static int calculate(int x,int y)
        {
            return x * y;

        }
        public int calculator(int x, int y)
        {
            return x * y;

        }
        public static string Name;
        public  string Name1="lucky";
        static Program()
        {
             
            Name = "key of success";
        }

        static void Main(string[] args)
        { 
            
            Console.WriteLine(calculate(3, 4));
            Program p = new Program();
            Console.WriteLine(p.calculator(4, 7));
            Console.WriteLine(Name);
            Console.WriteLine(p.Name1);

        }
    }
}
