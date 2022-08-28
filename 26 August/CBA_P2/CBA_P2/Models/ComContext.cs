using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CBA_P2.Models
{
    public class ComContext:DbContext
    {
        public ComContext() : base("ComContext")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}