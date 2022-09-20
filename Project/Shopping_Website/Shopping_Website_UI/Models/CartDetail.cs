using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website_UI.Models
{
    public class CartDetail
    {
        public int Id { get; set; }
        public int Productid { get; set; }
        public int Customerid { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Visible { get; set; }

        public virtual UserDetail UserDetail { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}