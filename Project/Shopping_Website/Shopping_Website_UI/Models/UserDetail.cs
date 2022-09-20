using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping_Website_UI.Models;

namespace Shopping_Website_UI.Models
{
    public class UserDetail 
    {
        public int Id { get; set; }

        [Remote("CheckUserName", "Home", ErrorMessage = "User Name Already Exits")]
        [Required(ErrorMessage ="Username is Required")]
 
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid")]
         public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password Contain at least 1 Capital ,1 Digit and total 8 letter")]
        public string Password { get; set; }

        [RegularExpression("[0-9a-zA-Z #,-]+", ErrorMessage = "Invalid")]
        public string Address { get; set; }

         [Required]
        [RegularExpression(@"\d{10}", ErrorMessage = "Enter the 10 digit Number")]
        public Nullable<long> Contactno   { get; set; }
        [Required(ErrorMessage = "Role is Required")]

        public String Role { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
         public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual RoleDetail RoleDetail { get; set; }
     }
}