using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website_UI.Models
{
    public class PaymentDetail
    {

        public int Id { get; set; }
        public int Userid { get; set; }
        public int Productid { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<long> Mobileno { get; set; }
        public Nullable<decimal> Totalamount { get; set; }
        public Nullable<System.DateTime> Orderdate { get; set; }
        public string Paymentmode { get; set; }
    }
}