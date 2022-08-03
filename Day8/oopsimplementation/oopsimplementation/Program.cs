using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsimplementation
{
    class HRmanagement {
        string _setloction;
        public void Manage()
        {
            Console.WriteLine("i am managing");
        }
        public string setlocation
        {
            set { _setloction = "dev"; }
            get
            {
                return _setloction;
            }
        }
    }
    class Employee:HRmanagement {
        string getwork;
        public Employee(Department dp)
        {
            getwork = dp.setwork;

        } 

        public void work()
        {
            base.Manage();
            Console.WriteLine("I am Working");
        }
        public void showwork()
        {
            Console.WriteLine("My project is "+getwork);
        }
    }
    class Department:HRmanagement {
        string getlocation,_setwork;
        public Department(HRmanagement hr)
        {
            getlocation = hr.setlocation;
        }
        public void Location()
        {
            Console.WriteLine("I am at "+getlocation);
        }
        public string setwork
        {
            set { _setwork = ".net"; }
            get { return _setwork; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            HRmanagement hr = new HRmanagement();
            Department dp = new Department(hr);           
            Employee em = new Employee(dp);
            em.work();
             
        }
    }
}
