using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CBA_P1.Models
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }

        public string Caddress { get; set; }

        [ForeignKey("Product")]
        public int Products_Pid { get; set; }
        public virtual Product Product { get; set; }

    }
}