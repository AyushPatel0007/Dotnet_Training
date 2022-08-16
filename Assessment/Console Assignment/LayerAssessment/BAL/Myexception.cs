using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Myexception:Exception
    {
        public void InvaildEnter()
        {
            Console.WriteLine("Invalid Enter");
        }
        public void reference()
        {
            Console.WriteLine("Reference");
        }
    }
}
