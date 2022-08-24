using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelDemo.Models;

namespace ModelDemo.Models
{
    public class Company
    {
        public Student Student { get; set; }
       public  Department Department { get; set; }
        public int Cid { get; set; }
        public String Cname { get; set; }
    }
}