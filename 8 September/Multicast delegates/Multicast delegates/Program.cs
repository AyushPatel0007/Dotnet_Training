using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_delegates
{
    internal class Program
    {
        public delegate void mydelegate(int a, int b);
        static void Main(string[] args)
        {
            mydelegate md = new mydelegate(Add);
            md += mul;
            md.Invoke(3, 2);

        }
        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        static void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
