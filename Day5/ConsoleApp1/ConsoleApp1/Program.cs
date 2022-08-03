using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsconcept
{
    internal class Processor
    {
        int abc,_empid;
        string xyz , _eaddress;
        public int empid
        {
            set { _empid = value; }
            get            {
                return _empid;
            }

        }
        public int ABC {
            
            set
            {
                abc = value;
            }
            get
            {
                return abc;
            }
        }
        public string EFG
        {
           
            set
            {
                xyz = value;
            }
            get
            {
                return xyz;
            }
        }
        public string eaddress
        {
            set { _eaddress = value; }
            get { return _eaddress; }
        }
    }

     
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();
            p.ABC = 51;
            p.EFG = "name";
            p.eaddress = "bly";
            p.empid = 101;
            Console.WriteLine(p.ABC);
            Console.WriteLine(p.EFG);
            Console.WriteLine(p.eaddress);
            Console.WriteLine(p.empid);



        }
    }
}
