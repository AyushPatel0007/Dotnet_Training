﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class StudentModel
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Semail { get; set; }
        public string Spassword { get; set; }
        public Nullable<int> Departments_Did { get; set; }

        public virtual DepartmentModel Department { get; set; }
    }
}
