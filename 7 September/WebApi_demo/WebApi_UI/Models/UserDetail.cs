using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_UI.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}