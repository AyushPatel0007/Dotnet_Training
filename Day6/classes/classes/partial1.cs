using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public partial class employee
    {
        string _fname,_lname,_address;
        double _salary;
        public string fname
        {
            get
            {
                return _fname;
            }
            set
            {
                _fname = value;
            }
        }

        public string lname
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }
        }

       public string address
        {
            get
            {
                return _address;
            }
            set
            {

                _address = value;
            }
        }


        public double salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        static void status()
        {
            Console.WriteLine("Ti is statys");
        }
    }
}
