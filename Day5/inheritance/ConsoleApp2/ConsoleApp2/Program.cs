using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class plane1
    {
        public virtual void status()
        {
            Console.WriteLine("Flying plane 1");
        }
    }
    class plane2 : plane1
    {
        public override void status()
        {
            Console.WriteLine("Plane 2");

        }
    }
    class Program
    {
        static void Main(string[] args) { 


           Plane3 p = new Plane3();
            p.status();
        }
    }
}
