using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataControl_Webform
{
    public class Author
    {
        public string first, last;
        public Author(string f,string l)
        {
            this.first = f;
            this.last = l;
        }
        public string _first { get { return first; }set { first = value; } }
        public string _last { get { return last; } set { last = value; } }

    }
}