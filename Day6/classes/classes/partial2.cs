using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public partial class  employee
    {
        public void detail()
        {
            Console.WriteLine("Your first name is "+_fname+" last name is "+_lname);
            Console.WriteLine("Your first name is {0}",  _fname);
        }
        public void detail2()
        {
            Console.WriteLine("salary : "+_salary);
            Console.WriteLine("Address : " + _address);
        }
    }
}
