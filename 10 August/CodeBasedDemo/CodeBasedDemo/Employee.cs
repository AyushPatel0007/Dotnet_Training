
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedDemo
{
   public class Employee
    {
        [Key]
        public int Did { get; set; }
        public int Eid { get; set; } 
        public string Ename { get; set; }
        public virtual Department Departments { get; set; }
    }
}
