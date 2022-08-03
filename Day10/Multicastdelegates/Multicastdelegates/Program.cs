using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicastdelegates
{
    public delegate void MultiCastDelegate(int x, int y);

    
    class Program
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Product" + (x + y));
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply" + (x * y));
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine("Divide" + (x / y));
        }
        public void Remainder(int x, int y)
        {
            Console.WriteLine("Product" + (x % y));
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            MultiCastDelegate obj2 = new MultiCastDelegate(obj1.Multiply);
            obj2 += obj1.Add;
            obj2 += obj1.Divide;
            obj2 += obj1.Remainder;
            obj2(50, 10);
            obj2 -= obj1.Add;
            obj2 -= obj1.Remainder;
            obj2(40, 10);
            Console.WriteLine("NOw try");
            foreach(MultiCastDelegate dele in obj2.GetInvocationList())
            {
                try
                {
                    dele.Invoke(40, 10);
                }
                catch(Exception e)
                {
                    Console.WriteLine(dele.Method.Name+e.Message);
                }
            }




            Console.ReadLine();


        }
    }
}
