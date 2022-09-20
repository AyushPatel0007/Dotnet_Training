using Shopping_Website.IRepository;
using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website.Repository
{
    public class CartRepository : ICartRepository
    {
        Shopping_DBEntities db = new Shopping_DBEntities();
        public int CartDeletebyId(int id)
        {

            var res = db.CartDetails.Where(x => x.Customerid == id).ToList();
            foreach (var CartDetail in res)
            {
                CartDetail.Visible = 2;
            }
           return  db.SaveChanges();
            

        }
        public int Addtocart(CartDetail c)
         {
            var res = db.CartDetails.FirstOrDefault(x => x.Customerid == c.Customerid && x.Productid == c.Productid&&x.Visible==1);
            if (res != null)
            {
                
                res.Quantity += c.Quantity;
            }
            else
            {
                db.CartDetails.Add(c);

            }
            return db.SaveChanges();

        }

        public List<CartDetail> Getallcartdetail()
        {
            List<CartDetail> lst= db.CartDetails.Where(x=>x.Visible==1).ToList();
            return lst;

        }

        public List<UserDetail> Getalluserdetail()
        {
            List<UserDetail> lst = db.UserDetails.Include("ProductDetail").ToList();
            return lst;

        }
        //by cutsomer id
        public List<GetCartDetail_Result> GetCartDetail(int id)
        {
           return db.GetCartDetail().Where(x => x.Customerid == id && x.Visible==1).ToList();
        }


        //by product id which is in cart
        public CartDetail GetCartDetailsbyproductid(int id)
        {
            return db.CartDetails.FirstOrDefault(x => x.Productid == id &&x.Visible==1);
        }





        //by product id that is  ordered
        public CartDetail GetOrderedCartDetailsbyproductid(int id)
        {
            return db.CartDetails.FirstOrDefault(x => x.Productid == id && x.Visible == 2);
        }


        //by cutsomer id that is  ordered
        public List<GetCartDetail_Result> GetCartDetailordered(int id)
        {
            return db.GetCartDetail().Where(x => x.Customerid == id && x.Visible == 2).ToList();
        }



        public int DeletefromCart(int id)
        {
            var res= db.CartDetails.FirstOrDefault(x=>x.Id==id);
            db.CartDetails.Remove(res);
            return db.SaveChanges();
        }


        public int Updatecart(CartDetail c)
        {
          
            var res= db.CartDetails.FirstOrDefault(x => x.Id == c.Id&&x.Visible==1);

            res.Quantity = c.Quantity;
            
           
            return db.SaveChanges();
        }

        public List<GetCartDetail_Result> OrderDetails(int id)
        {
            var res = db.GetCartDetail().Where(x => x.Customerid == id && x.Visible == 2).ToList();
            return res;
        }
      

        public int Paymentdetail(Paymentdetail obj)
        {
            var res = db.GetCartDetail().Where(x => x.Customerid == obj.Userid && x.Visible == 1).ToList();
            Decimal sum = 0;
            int quant = 0;
            var user = db.UserDetails.FirstOrDefault(x => x.Id == obj.Userid);
            if (obj.Name == "")
            {
                obj.Name = user.Username;
            }
            if (obj.Address == "")
            {
                obj.Address = user.Address;
            }
            if (obj.Mobileno == null)
            {
                obj.Mobileno = 91;
            }
            obj.Productid = 1;
            foreach (var r in res)
            {
                decimal i = 0;
                i = Convert.ToDecimal(r.Price * r.Quantity);
                i = i * Convert.ToDecimal(r.Discount)/ 100;
                sum += Convert.ToDecimal(r.Price * r.Quantity) - i;
                quant += Convert.ToInt32(r.Price * r.Quantity);

            }
            obj.Quantity = quant;

            obj.Email = user.Email;
            obj.Totalamount = sum;
            DateTime now = new DateTime();

            db.Paymentdetails.Add(obj);
           return db.SaveChanges();

        }

    }
}