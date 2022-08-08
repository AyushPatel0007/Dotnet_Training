using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var query = from obj in lst
                        where obj > 2
                        select obj;
            foreach(var ob in query)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
