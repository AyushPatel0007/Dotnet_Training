using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppModel
{
    public class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Semail { get; set; }
        public string Spassword { get; set; }
        public Nullable<int> Departments_Did { get; set; }

        public virtual Department Department { get; set; }
    }
}
