using Shopping_Website.IRepository;
using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shopping_Website.Controllers
{
    [Authorize(Roles="buyer")]
     public class BuyerController : ApiController
    {
        //Shopping_DBEntities db = new Shopping_DBEntities();

        private IProductRepository productrepository = null;
        private ICartRepository cartrepository = null;
        public BuyerController(IProductRepository _productrepository, ICartRepository _cartrepository)
        {
            productrepository = _productrepository;
            cartrepository = _cartrepository;
        }

      

        //Add the detial in cart
        [HttpPost]
        [Route("Buyer/AddToCart")]
        public IHttpActionResult AddToCart(CartDetail c)
        {
            int x = cartrepository.Addtocart(c);
            if (x == 0)
            {
                return NotFound();
            }
            return Ok(x);
        }


       
        //delete from cart 

        [HttpGet]
        [Route("Buyer/DeleteFromCart/{id}")]
        public IHttpActionResult DeletefromCart(int id)
        {
            int x = cartrepository.DeletefromCart(id);
            if (x == 0)
            {
                return NotFound();
            }
            return Ok(x);
        }


        //update the cart
        [HttpPost]
        [Route("Buyer/UpdateCart")]
        public IHttpActionResult UpdateCart(CartDetail c)
        {
            int x = cartrepository.Updatecart(c);
             
            return Ok(x);
        }

        //get cart by id

        [HttpGet]
        [Route("Buyer/GetCartDetail/{id}")]
        public IHttpActionResult GetCartDetail(int id)
        {
            return Ok(cartrepository.GetCartDetail(id));
        }


        //delete the product detail from cart

        [HttpGet]
        [Route("Buyer/CartDeletebyId/{id}")]
        public IHttpActionResult CartDeletebyId(int id)
        {
           
            
            return Ok(cartrepository.CartDeletebyId(id));

        }

        //get the product detail from cart by id 
        [HttpGet]
        [Route("Buyer/GetCartDetailbyproductid/{id}")]
        public IHttpActionResult GetCartDetailbyproductid(int id)
        {
            CartDetail  res= cartrepository.GetCartDetailsbyproductid(id);
            return Ok(res);
        }


        //ordered details by id

        [HttpGet]
       [Route("Buyer/OrderDetailbyProductId/{id}")]
        public IHttpActionResult GetOrderedCartDetailsbyproductid(int id)
        {
            return Ok(cartrepository.GetOrderedCartDetailsbyproductid(id));
        }
        //get product detail
        [HttpGet]
        [Route("Buyer/GetAllCartDetail")]
        public IHttpActionResult GetAllCartDetail()
        {
            List<CartDetail> lst = cartrepository.Getallcartdetail();
            return Ok(lst);
        }



        //by cutsomer id is in ordered
        [HttpGet]
        [Route("Buyer/OrderDetails/{id}")]
        public  IHttpActionResult OrderDetails(int id)
        {
             return Ok(cartrepository.OrderDetails(id));
        }



        //payemnet detail
        [HttpPost]
        [Route("Buyer/Paymentdetail")]
        public  IHttpActionResult  Paymentdetail(Paymentdetail obj)
        {
            return Ok(cartrepository.Paymentdetail(obj));



        }
        //All Product details

        [HttpGet]
        [Route("Buyer/GetProductDetails")]
        public IHttpActionResult GetProductDetails()
        {
            
            return Ok(productrepository.Getallproduct());



        }

    }
}
