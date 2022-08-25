using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Twotable_cba.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }

        [Required(ErrorMessage ="Enter name")]

        public string Sname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Enter Email")]
          public string Semail { get; set; }

        public string Spassword { get; set; }

        [ForeignKey("Department")]
        
        public int Departments_Did { get; set; }
        public virtual Department Department { get; set; }
    }
}