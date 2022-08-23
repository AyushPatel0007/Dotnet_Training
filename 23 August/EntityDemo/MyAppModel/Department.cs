using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppModel
{
    public class Department
    {
        public int Did { get; set; }
        public string Dname { get; set; }

         public virtual ICollection<Student> Students { get; set; }
    }
}
