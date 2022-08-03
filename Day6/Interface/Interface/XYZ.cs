using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class XYZ:Iwork
    {   
        public int calc()
        {
            Console.WriteLine("XYZ calc Interface");
            return 5;
        }

        public void Network()
        {
            Console.WriteLine("XYZ N/w Interface");
        }

        public void work()
        {
            Console.WriteLine("XYZ Work Interface");
        }
    }
}
