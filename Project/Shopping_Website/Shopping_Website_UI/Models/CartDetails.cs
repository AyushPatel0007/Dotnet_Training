using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website_UI.Models
{
    public class CartDetails
    {
        //all data from 
        public int Id { get; set; }
        public int Customerid { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int Productid { get; set; }
        public Nullable<int> Visible { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Imageurl { get; set; }
        public string Size { get; set; }
    }
}