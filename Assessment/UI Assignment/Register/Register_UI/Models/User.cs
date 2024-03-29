﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Register_UI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]

        public string UserName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Valid Email")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public string Cpassword { get; set; }
        [RegularExpression("^[a-zA-Z ]*$")]
        public string City { get; set; }
    }
}