using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop_Assessment.Models
{
    public class ShopDb:DbContext
    {
        public ShopDb() : base("ComContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>Products{ get; set; }
        public DbSet<ViewAll> ViewAlls { get; set; }
    }
}