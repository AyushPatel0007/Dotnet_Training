using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataControl_Webform
{
    public class Publisher
    {
        public List<Author> AddedList(string s)
        {
            List<Author> lst = new List<Author>();
            if(s=="washington")
            {
                lst.Add(new Author("adam", "hy"));
                lst.Add(new Author("adam2", "hy2"));
                lst.Add(new Author("adam3", "hy3"));


            }
            return lst;
        }
    }
}