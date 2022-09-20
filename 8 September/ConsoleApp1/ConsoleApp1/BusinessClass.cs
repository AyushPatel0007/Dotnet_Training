using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BusinessClass
    {
        //private IDepartment nonassign;
        //public IDepartment ayega
        //{
        //    set
        //    {
        //        nonassign = value;
        //    }
        //    get
        //    {
        //        return nonassign;
        //    }
        //}



        public List<Department> rightvalue(IDepartment nonassign)
        {
            return nonassign.GetData();
        }
    }
}
