using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionExcersice
{
    class Myexception:Exception
    {
        public void Valid()
        {
            Console.WriteLine("Enter Valid nummber");
        }
        public void Senter()
        {
            Console.WriteLine("Enter Correct datatype");
        }
        public void Notavailable()
        {
            Console.WriteLine("Furniture type invalid");
        }
    }
}
