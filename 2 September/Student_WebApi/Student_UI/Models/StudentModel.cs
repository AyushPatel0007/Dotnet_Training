using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_UI.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Name")]
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Required Email")]
        [RegularExpression(@"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$", ErrorMessage = "Enter Valid Id")]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required Password")]
        [DataType(DataType.Password)]
        //[Compare("Password")
        public string Password { get; set; }
    }
}