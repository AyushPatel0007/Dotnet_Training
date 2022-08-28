using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBA_P2.Models
{
    public class Product
    {

        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }

         public DateTime Purchase { get; set; }
     }
}