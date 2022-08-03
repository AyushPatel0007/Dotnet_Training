using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsconcept
{
     

    abstract class Remote {
        public void status()
        {
            Console.WriteLine("Remote class");
        }
        public void price(int retail)
        {
            Console.WriteLine("Retail Price of Remote is:" + retail.ToString());
        }
        public void price(int retail,int market)
        {
            Console.WriteLine("Customer Price of Remote is:" + (retail+market).ToString());
        }

        public abstract void volume();
 
       
    }

    class Samsung : Remote 
    {
        public override void volume()
        {
            base.price(2500);
            base.price(2500,550);
            Console.WriteLine("samsung remote uses Increment/decrement volume");
            
        }
    }
    class Lg : Remote
    {
        public override void volume()
        {
            base.price(1500);
            base.price(1500,550);
            Console.WriteLine(" Lg remote uses plus/minus volume");
 
        }
    }
    class Mi : Remote
    {
        public override void volume()
        {
            base.price(100);
            base.price(100, 550);
            Console.WriteLine("Mi remote uses Increment/decrement volume");
 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mi m = new Mi();
            m.volume();


        }
    }
}
