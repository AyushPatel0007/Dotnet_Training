using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public  class Program
    {
        static void Main(string[] args)
        {

            StudentBusinessLogic st = new StudentBusinessLogic();
            st.studentdata = new StudentDataAccessLayer();
            var res = st.getval();

        }
    }
   













    public interface IStudent
    {
        List<Student> Getdata();
    }


     























    



























 
}
