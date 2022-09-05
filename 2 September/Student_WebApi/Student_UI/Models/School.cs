using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_UI.Models
{
    public class School
    {
        public int Sid { get; set; }

        public string Name { get; set; }

        public ICollection<StudentModel> studentModels { get; set; }
    }
}