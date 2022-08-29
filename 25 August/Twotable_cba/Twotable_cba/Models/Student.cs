using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Twotable_cba.Models
{
    public class Student
    {
        [Key] //pk
        public int Sid { get; set; }

        [Required(ErrorMessage ="Enter name")]

        public string Sname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter Email")]
        public string Semail { get; set; }
        [DataType(DataType.Password)]
       
        public string Spassword { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Department")] //fk
        
        public int Departments_Did { get; set; }
        public virtual Department Department { get; set; }
    }
}