﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _5_september_Task.Models
{
    public class User
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