using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class ComContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public ComContext() : base("ComContext")
        {

        }
    }
}