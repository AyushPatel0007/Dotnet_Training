using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api_Practise_.Models
{
    public class ComContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public ComContext() : base("ComContext") { }


    }
}