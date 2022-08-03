using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDemo
{
    class Program
    {
        delegate void operation();
        delegate void operation1();
        static void Main(string[] args)
        {
            operation obj = delegate
            {
                Console.WriteLine("I am delegates ");
            };
            operation1 obj1 = delegate
            {
                Console.WriteLine("I am delegates 1 ");
            };
            obj();
            obj1();
            Console.ReadLine();
        }
    }
}
