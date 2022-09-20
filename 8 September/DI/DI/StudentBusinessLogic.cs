using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class StudentBusinessLogic
    {
        private IStudent istudent;
        public IStudent studentdata
        {
            set
            {
                istudent = value;
            }
            get
            {
                if (istudent == null)
                {
                    throw new Exception("invalid");
                }
                return istudent;
            }
        }
        public List<Student> getval()
        {
            return istudent.Getdata();
        }
    }
}
