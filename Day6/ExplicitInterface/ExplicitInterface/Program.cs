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
    interface Iglobal
    {
        void Network();
    }
    class Abc 
    {
        public void Network()
        {
            Console.WriteLine("Abc");
        }
    }
    class Myclass :   Abc,IACT , Iglobal
    { 

        void IACT.Network()
        {

            base.Network();
            Console.WriteLine("IACT N/w Interface");
        }
        void Iglobal.Network()//explicit
        {
            Console.WriteLine("Global N/w Interface");
        }

         
    }
    
    class Program

    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            Iglobal i = new Myclass();
            IACT ia = new Myclass();
            
            i.Network();//explicit call
            ia.Network();
             
        }
    }
}
