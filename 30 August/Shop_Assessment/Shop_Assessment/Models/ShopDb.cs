using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop_Assessment.Models
{
    public class ShopDb : DbContext
    {
        public ShopDb() : base("ComContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ViewAll> ViewAlls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .MapToStoredProcedures(p => p.Insert(sp => sp.HasName("sp_InsertProduct").Parameter(pm => pm.Name, "name").Parameter(pm => pm.Price, "price").Parameter(pm => pm.Categories_Cid, "cid").Result(rs => rs.Pid, "Id"))
                    .Update(sp => sp.HasName("sp_UpdateProduct").Parameter(pm => pm.Name, "name").Parameter(pm => pm.Price, "price").Parameter(pm => pm.Categories_Cid, "cid"))
                    .Delete(sp => sp.HasName("sp_DeleteProduct").Parameter(pm => pm.Pid, "Id"))
                   
           
                    );
            modelBuilder.Entity<Category>()
           .MapToStoredProcedures(p => p.Insert(sp => sp.HasName("sp_InsertCategory").Parameter(pm => pm.Cname, "name").Result(rs => rs.Cid, "Id"))
           );

        }



         
        
    }
}