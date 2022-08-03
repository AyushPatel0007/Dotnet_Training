using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Class1 pro = new Class1(); 
            Console.WriteLine("Addition result:{0}",pro.add(10, 20));
            Console.WriteLine("Multiply result:{0}", pro.mult(10, 20));
            Console.WriteLine("Division result:{0}", pro.div(10, 20));
            Console.WriteLine("Subract result:{0}", pro.sub(10, 20));
        } 
    }
}
