using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal class MyException:Exception
    {
        public void Connect()
        {
            Console.WriteLine("Connection not establish");
        }
    }
}
