using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_delegates
{
    internal class Program
    {
        public delegate void Mydelegates(int z, int b);
        static void Main(string[] args)
        {
            Mydelegates md1 = Add;
            Mydelegates md2 = (int a, int b) => Console.WriteLine(a + b); ;
            Mydelegates md = new Mydelegates(Add);
            Invokemydelegate(md1);

        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Invokemydelegate(Mydelegates md1)
        {
            md1(1, 2);
        }

    }
}
