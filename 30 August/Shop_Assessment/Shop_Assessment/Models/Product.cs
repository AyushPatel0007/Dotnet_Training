using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shop_Assessment.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Name{ get; set; }
        public int Price { get; set; }
        [ForeignKey("Category")]
        public int Categories_Cid { get; set; }
        public virtual Category Category { get; set; }
    }
}