using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealedemo
{
    class Program
    {
        sealed class demo
        {
            public void add()
            {
                Console.WriteLine("i am from sealed class");
            }
        }
        class b { }

        static void Main(string[] args)
        {
            demo d = new demo();
            d.add();
        }
    }
}
