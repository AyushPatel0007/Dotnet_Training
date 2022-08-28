using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedure_CBA.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Purchase { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}