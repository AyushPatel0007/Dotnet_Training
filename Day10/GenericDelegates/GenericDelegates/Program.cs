using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Myclass { 
        public static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }
        public static void sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static int multi(int a, int b)
        {
            return(a * b);
        }
        public static void add(string a, string b)
        {
            Console.WriteLine(a +" "+ b);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> a = new Action<int, int>(Myclass.sum);
            a(1, 4);
            Action<string, string> s = new Action<string, string>(Myclass.add);
            s("luck", "luck");
            Func<int, int, int> f = new Func<int, int, int>(Myclass.multi);
            Console.WriteLine(f(3,6));

            Predicate<string> p = new Predicate<string>(Myclass.IsDate);
            if (p("10-06-2000"))
            {
                Console.WriteLine("Valid");
            }
            else { 
                Console.WriteLine("Invalid");
            }
        }
    }
}
