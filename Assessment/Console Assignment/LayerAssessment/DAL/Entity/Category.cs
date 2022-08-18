using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Category
    {

        public string Cid, Cname;
        public Category(string n)
        {
            this.Cname=n;
        }
         public string _Cname { get { return Cname; } set { Cname = value; } }
    }
}
