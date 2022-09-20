using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website.IRepository
{
    public interface ICartRepository
    {
        int CartDeletebyId(int id);
        int Addtocart(CartDetail c);
        List<CartDetail> Getallcartdetail();
        int DeletefromCart(int id);
        int Updatecart(CartDetail c);
        List<UserDetail> Getalluserdetail();
        List<GetCartDetail_Result> GetCartDetail(int id);
        CartDetail GetCartDetailsbyproductid(int id);
        List<GetCartDetail_Result> GetCartDetailordered(int id);
        CartDetail GetOrderedCartDetailsbyproductid(int id);
        List<GetCartDetail_Result> OrderDetails(int id);
        int Paymentdetail(Paymentdetail obj);

    }
}