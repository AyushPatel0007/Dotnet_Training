﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_Assessment.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Cpassword { get; set; }
        public string City { get; set; }
    }
   
 
}