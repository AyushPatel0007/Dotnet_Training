using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gc_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            long available = GC.GetTotalMemory(false);
            Console.WriteLine("{0:N0}", available);
            int asize = 20000000;
            byte[] bigarray = new byte[asize];
            GC.Collect();
            available = GC.GetTotalMemory(true);
            
            Console.WriteLine("{0:N0}", available);
            Console.WriteLine(available);
            Console.ReadLine();

        }
    }
}
