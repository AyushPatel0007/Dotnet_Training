using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTableAdo
{
    internal class Department
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }

     }
}
