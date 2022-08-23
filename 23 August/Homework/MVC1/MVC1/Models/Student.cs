using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Student
    {

        public int Sid { get; set; }
        public string Sname { get; set; }
         public string Semail { get; set; }
        public string Spassword { get; set; }

        public int Departments_Did { get; set; }


    }
}