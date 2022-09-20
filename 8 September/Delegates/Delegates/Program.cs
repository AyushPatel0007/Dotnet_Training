using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        public delegate void Mydelegates(int z,int b);
        static void Main(string[] args)
        {
            Mydelegates md1 =  Add;
            Mydelegates md2 = (int a, int b) => Console.WriteLine(a+b); ;
            Mydelegates md = new Mydelegates(Add);
            md.Invoke(2, 4);
            md2(2, 5);

        }
        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
