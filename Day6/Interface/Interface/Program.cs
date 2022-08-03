using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{ 
    interface IACT
    {
        void Network();

    }
    class Myclass :Iwork,IACT,Icommunication
    {
        public int calc()
        {
            Console.WriteLine("calc Interface");
            return 4;
        }

        public void CNN()
        {
            Console.WriteLine("Cnn Interface");
        }

        public void Network()
        {
            Console.WriteLine("N/w Interface");
        }

        public void work()
        {
            Console.WriteLine("Work Interface");
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            XYZ obj1 = new XYZ();
            obj1.work();
            obj.work();
        }
    }
}
