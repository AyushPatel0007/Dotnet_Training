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

            //collection Data source
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };


            //Linq query using query 
            var query = from obj in lst
                        where obj > 2
                        select obj;
            foreach(var ob in query)
            {
                Console.WriteLine(ob);
            }

            //Linq query using method  

            IEnumerable<int> rs = lst.Where(n => n > 3).ToList();
            foreach (var ob in rs)
            {
                Console.WriteLine(ob);
            }

        }
    }
}
