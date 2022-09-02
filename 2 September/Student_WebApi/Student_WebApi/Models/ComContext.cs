using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_WebApi.Models
{
    public class ComContext:DbContext
    {
        public DbSet<StudentModel> StudentModels { get; set; }
        public ComContext() : base("Comcontext")
        {

        }
    }
}