using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi_Assessment.Models;

namespace WebApi_Assessment.Models
{
    public class ComContext:DbContext
    {
        public ComContext() : base("ComContext")
        {

        }
        public DbSet<StudentModel> StudentModels { get; set; }
        
    }

     
}