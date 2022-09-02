using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi_Demo_Ui.Models
{
    public class ComContext:DbContext
    {
        public DbSet<RechargeModel> RechargeModels { get; set; }
    }
}