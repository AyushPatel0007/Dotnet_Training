using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping_Website_UI.Models
{
    public class ProductDetail
    {

         
   
        public int Id { get; set; }
        public int Sellerid { get; set; }

        [RegularExpression(@"^[a-zA-Z_ ]+$", ErrorMessage = "Use letters only please")]
        [Required]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the description about the product "), MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z_ ]+$", ErrorMessage = "Use letters only please")]
        public string Description { get; set; }


        [Required]
        [RegularExpression(@"^[a-zA-Z_ ]+$", ErrorMessage = "Use letters only please")]
        public string Category { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Use Number only please")]

        public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Use Number only please")]

        public int Discount { get; set; }
        public DateTime Publish { get; set; }
         public string Imageurl { get; set; }
        public string Size { get; set; }


         public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}