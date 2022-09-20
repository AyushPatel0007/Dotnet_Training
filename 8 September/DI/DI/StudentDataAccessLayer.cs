using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{


    //repo
    public class StudentDataAccessLayer:IStudent
    {
        public List<Student> Getdata()
        {
            List<Student> lst = new List<Student>()
            {
                new Student(){Id=1,Name="sds" },
                new Student(){Id=2,Name="dwe"}
            };
            return lst;
        }
    }
}
