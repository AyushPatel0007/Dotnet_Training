using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedDemo
{
      public class Department
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }
        public string Ddesc { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
