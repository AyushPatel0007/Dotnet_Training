using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Myclass {
        public Nullable<int> i;

   }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            if (my.i == null)
            {
                Console.WriteLine("It is Null");
            }
            else
            {
                Console.WriteLine(my.i.Value);
            }


            int? x=null;
            int y=x?? 0;
            Console.WriteLine(y);
            Nullable<int> n = null;
            if (n == null)
            {
                Console.WriteLine("It is Null");
            }
            else
            {
                Console.WriteLine(my.i.Value);
            }


        }
    }
}
