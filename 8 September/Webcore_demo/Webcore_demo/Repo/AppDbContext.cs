using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Webcore_demo.Repo
{
    public class AppDbContext:DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<UserDetail> UserDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder m)
        {
            m.Entity<UserDetail>().HasData(
                new UserDetail
                {
                     UserName = "ank",
                    Password = "123",
                    Roles = "user"

                }
            );

        }
    }
   
    


}
