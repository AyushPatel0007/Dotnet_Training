using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBAprroach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var Context=new demoEntities())
            {

                var result = Context.Students;
                foreach(var item in result)
                {
                    Console.WriteLine(item.Id+" "+item.Name+" "+item.Marks+" "+item.Address);
                 }
            }
        }
    }
}
