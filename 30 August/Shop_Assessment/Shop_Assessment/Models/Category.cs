using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop_Assessment.Models
{
    public class Category
    {
        [Key]
        public int Cid { get; set; }
        public string  Cname { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}