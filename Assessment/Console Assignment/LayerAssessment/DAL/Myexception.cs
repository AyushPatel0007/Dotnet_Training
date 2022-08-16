using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Myexception:Exception
    {
        public void Connectionerror()
        {
            Console.WriteLine("---------Connection Not Established-----");
        }
        public void TableNotFound()
        {
            Console.WriteLine("------Table Not found---------");
        }
        public void reference()
        {
            Console.WriteLine("Reference");
        }
    }
}
