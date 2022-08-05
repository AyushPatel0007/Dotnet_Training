using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class CheckBalanceException : Exception {

        public void Balance()
        {
            Console.WriteLine("Balanace is less than 500");
        }
        public void Trans()
        {
            Console.WriteLine("Write Correct Transaction Type");
        }
    }
}
