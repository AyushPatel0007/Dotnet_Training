using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_WebApi.Models
{
    public class School
    {
        [Key]
        public int Sid { get; set; }

        public string Name { get; set; }

        public ICollection<StudentModel> studentModels { get; set; }
    }
}