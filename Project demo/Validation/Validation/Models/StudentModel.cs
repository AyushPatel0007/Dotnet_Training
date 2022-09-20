using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter phone")]
        public string Phone { get; set; }

         
    }
}