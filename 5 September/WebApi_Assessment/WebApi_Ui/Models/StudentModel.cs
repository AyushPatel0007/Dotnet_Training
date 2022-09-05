using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_Ui.Models
{
    public class StudentModel
    {
        [Key]//id is primary key
        public int Id { get; set; }


        //username

        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Required(ErrorMessage ="Enter Username")]
        public string UserName { get; set; }


        //Email
        [Required(ErrorMessage = "Enter Email")]

        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Valid Email")]
        public string Email { get; set; }


        //password
        [DataType(DataType.Password, ErrorMessage = "Enter Valid Password")]
        public string Password { get; set; }

        //Confirmpassword
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password, ErrorMessage = "Enter Valid Password")]
        public string Cpassword { get; set; }


        //City
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage ="Password Must Contain only alphabet ")]
        public string City { get; set; }
    }
}