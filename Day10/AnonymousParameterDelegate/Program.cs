using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnonymousParameterDelegate
{
    public delegate void Print(int value);

    class Program
    {
        public static void PrintHelperMethod(Print printdel, int value)
        {
            value += 10;
            printdel(value);
        }
        static void Main(string[] args)
        {
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Anony {0}", val);
            }, 100);


        }
    }
}
