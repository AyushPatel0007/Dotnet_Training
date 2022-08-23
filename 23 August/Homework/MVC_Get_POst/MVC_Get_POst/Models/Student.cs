using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Get_POst.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Please enter the id")]
        [Range(15,100)]
        public int id { get; set; }
        [Required]
        [EmailAddress]
        public string Name { get; set; }
        [Required]
        [ValidCheck]
        public string Address { get; set; }
    }
}