using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo
{



    class Program
    {
        static void message()
        {
            Console.WriteLine("I am odd");
        }

        static void message1()
        {
            Console.WriteLine("I am even");
        }
        static void Main(string[] args)
        {
            AddTwoNumber a = new AddTwoNumber();
            a.ev_oddnumber += new AddTwoNumber.dg_oddnumber(message);
            a.ev_evennumber += new AddTwoNumber.dg_oddnumber(message1);
            a.Add();
            Console.Read();
        }
    }

 

    class AddTwoNumber {
        public delegate void dg_oddnumber();
        public event dg_oddnumber ev_oddnumber;
        public event dg_oddnumber ev_evennumber;
        public void Add()
        {
            int result = 10;
            Console.WriteLine(result);
            if ((result % 2 != 0) && (ev_oddnumber != null))
            {
                ev_oddnumber();
            }
            else
            {
                ev_evennumber();
            }
        }


    }

}
