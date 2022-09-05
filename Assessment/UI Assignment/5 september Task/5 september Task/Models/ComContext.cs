using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _5_september_Task.Models
{
    public class ComContext:DbContext
    {
        public ComContext() : base("ComContext")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}