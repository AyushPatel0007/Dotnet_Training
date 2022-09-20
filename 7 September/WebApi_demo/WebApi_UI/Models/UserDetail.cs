using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_UI.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter nah")]
        public string UserName { get; set; }
        

        public HttpPostedFileBase ProfileImage { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter nah")]
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}