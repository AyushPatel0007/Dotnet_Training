using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop_Assessment.Models
{
    public class ViewAll
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}