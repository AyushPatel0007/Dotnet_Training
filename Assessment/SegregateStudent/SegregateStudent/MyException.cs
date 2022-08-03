using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregateStudent
{
    class MyException:Exception
    {
        public void Invalidno()
        {
            Console.WriteLine("*******************Enter ValidNumber************************");
        }
        public void EnterString()
        {
            Console.WriteLine("*******************Enter String************************");
        }
        public void Enterint()
        {
            Console.WriteLine("*******************Enter int************************");
        }
    }
}
