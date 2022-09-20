using Shopping_Website.IRepository;
using Shopping_Website.Models;
using Shopping_Website.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 
namespace Shopping_Website.Controllers
{
    [Authorize(Roles = "seller")]
  
    public class SellerController : ApiController
    {
        //Shopping_DBEntities db = new Shopping_DBEntities();
        private IProductRepository productrepository = null;
        private ICartRepository cartrepository = null;
        public SellerController(IProductRepository _productrepository, ICartRepository _cartrepository)
        {
            productrepository = _productrepository;
            cartrepository = _cartrepository;
        }


        //insert the product by detail
        [HttpPost]
        [Route("Seller/InsertData")]
        public IHttpActionResult InsertData(ProductDetail sp)
        {
             return Ok(productrepository.InsertData(sp));

        }


        //get the product detail by id

        [HttpGet]
        [Route("Seller/DisplayData/{id}")]
        public IHttpActionResult GetData(int id)
        {
            return Ok(productrepository.GetData(id));
        }

        //update the product by id
        [HttpPut]
        [Route("Seller/UpdateData")]
        public IHttpActionResult UpdateData(ProductDetail std)
        {

            return Ok(productrepository.UpdateData(std));

        }


        //get the seller id by id
        [HttpGet]
        [Route("Seller/SelectData/{id}")]
        public IHttpActionResult SelectData(int id)
        {
            var res = productrepository.SelectData(id);
            return Ok(res);
        }

       

    }
}
