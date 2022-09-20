using Newtonsoft.Json;
using Shopping_Website_UI.Customer_Filter;
using Shopping_Website_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Shopping_Website_UI.Controllers
{
    //custom error redirect to error page

    [HandleError]
    [SessionFilter]
    public class BuyerController : Controller
    {



        //Buyer/Index
        //index page of buyer show tg eproduct detail
       
        public ActionResult Index()
        {
 
            
                return View();
            
         }

        //for ajax call
        public JsonResult GetProducts()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:/");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());

                    string s = webClient.DownloadString("https://localhost:44307/Buyer/GetProductDetails");
                    List<ProductDetail> lst = JsonConvert.DeserializeObject<List<ProductDetail>>(s);
                    return Json(lst, JsonRequestBehavior.AllowGet);


                }
            }

            catch (Exception e)
            {
                throw new Exception("Invalid Data show");
            }
        }

        //pass all the product detail to dropdown
    
        public JsonResult GetProductx()
        
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:/");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());

                    string s = webClient.DownloadString("https://localhost:44307/Buyer/GetProductDetails");
                    List<ProductDetail> lst = JsonConvert.DeserializeObject<List<ProductDetail>>(s);
                      var lstt = lst.Select(x => new { x.Name, x.Gender, x.Category, x.Size }).ToList();
                    return Json(lst,JsonRequestBehavior.AllowGet);


                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Data show");
            }
        }



        //Add product in the cart
        public ActionResult AddinCart(int id)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    CartDetail cd = new CartDetail();
                    cd.Productid = id;
                    cd.Quantity = 1;
                    cd.Visible = 1;
                    cd.Customerid = Convert.ToInt32(Session["id"]);
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:*/*");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());

                    string s = webClient.UploadString("https://localhost:44307/Buyer/AddToCart", "POST", JsonConvert.SerializeObject(cd));
                    int result = JsonConvert.DeserializeObject<int>(s);

                    if (result == 0)
                    {
                        
                        TempData["update"] = "Not deleted";
                        return RedirectToAction("AddToCart");
                    }
                    return RedirectToAction("AddToCart");


                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Action Performed");
            }


        }


        //Buyer/AddToCart
        //View Page of the AddtoCart
        [HttpGet]
        public ActionResult AddToCart()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {

                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:Applictaion/json");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());
                    string s = webClient.DownloadString("https://localhost:44307/Buyer/GetCartDetail/" + Session["id"].ToString());
 
                    List<CartDetails> lst = JsonConvert.DeserializeObject<List<CartDetails>>(s);
                    return View(lst);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Action Performed");
            }



        }

        
         [Route("FilterData")]
        public JsonResult GetCartDetailbyproductid(int id)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:/");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());

                    string s = webClient.DownloadString("https://localhost:44307/Buyer/GetCartDetailbyproductid/"+id.ToString());
                    CartDetail lst = JsonConvert.DeserializeObject< CartDetail> (s);
                   
                    return Json(lst, JsonRequestBehavior.AllowGet);


                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Data get by id");
            }
        }


        //Delete the product from the cart
        [HttpGet]
        public ActionResult DeletefromCart(int id)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    CartDetail cd = new CartDetail();
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:*/*");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());


                    string s = webClient.DownloadString("https://localhost:44307/Buyer/DeleteFromCart/" + id.ToString());
                    return RedirectToAction("AddToCart");


                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Action Performed");
            }


        }

        //update the product values(quantity)
       
        public ActionResult UpdateCart(CartDetail cd)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    
                    cd.Customerid = Convert.ToInt32(Session["id"]);
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:*/*");
                    string str = Session["token"].ToString();
                    cd.Visible = 1;
                    cd.Quantity =cd.Quantity;
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());
                    string s = webClient.UploadString("https://localhost:44307/Buyer/UpdateCart", "POST", JsonConvert.SerializeObject(cd));
                    int result = JsonConvert.DeserializeObject<int>(s);
                    if (result == 0)
                    {
                        TempData["update"] = "Not Updated";
                       
                    }
                    return RedirectToAction("AddToCart");


                }
            }
            catch (Exception e)
            {
                throw new Exception("Invalid Data Added");
            }


        }


        //Buyer/Profile
        //get the profile of the buyer/customer
        [HttpGet]
        public  ActionResult Profile()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    string res = webClient.DownloadString("https://localhost:44307/Home/GetUser/" + Session["username"]);
                    var list = JsonConvert.DeserializeObject<UserDetails>(res);
                    return View(list);
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid Action Performed");
            }

        }



        //Edit the Profile
        [HttpGet]
        public ActionResult EditProfile()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    string res = webClient.DownloadString("https://localhost:44307/Home/SelectData/" + Session["id"].ToString());
                    return View(JsonConvert.DeserializeObject<UserDetails>(res));
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid Action Performed");
            }
        }




        [HttpPost]
        public ActionResult EditProfile(UserDetails std)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (WebClient webClient = new WebClient())

                    {
                        std.Id = Convert.ToInt32(Session["id"]);
                        webClient.Headers.Add("Content-type:application/Json");
                        webClient.Headers.Add("Accept:application/Json");
                        string a = webClient.UploadString("https://localhost:44307/Home/UpdateData", "PUT", JsonConvert.SerializeObject(std));
                        return RedirectToAction("Profile");

                    }
                }
                catch (Exception)
                {
                    throw new Exception("Invalid Action Performed");
                }
            }
            else
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    string res = webClient.DownloadString("https://localhost:44307/Home/SelectData/" + Session["id"].ToString());
                    return View(JsonConvert.DeserializeObject<UserDetails>(res));
                }
               

            }

        }


        //payment product
        public ActionResult ProductPayment()
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    ViewBag.list = new List<string>() { "UPI", "Card" };

                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:Applictaion/json");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());
                    string s = webClient.DownloadString("https://localhost:44307/Buyer/GetCartDetail/" + Session["id"].ToString());

                    List<CartDetails> lst = JsonConvert.DeserializeObject<List<CartDetails>>(s);
                    return View(lst);
                }
            }catch(Exception e)
            {
                throw new Exception();
            }

           
        }

        [HttpPost]
        public string MakePayment(string Name,string Address,string Mobileno,string Mode)
        {
            
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string str = Session["token"].ToString();
                webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());


                PaymentDetail pay = new PaymentDetail();
                pay.Name = Name;
                
                pay.Address = Address;
                pay.Mobileno = Convert.ToInt64(Mobileno);
                pay.Userid = Convert.ToInt32(Session["id"]);
                if (Convert.ToInt32(Mode) == 1)
                {
                    pay.Paymentmode = "Cash on Delivery";
                }
                else
                {
                    pay.Paymentmode = "Card";
                }

                 webClient.UploadString("https://localhost:44307/Buyer/Paymentdetail/","POST",JsonConvert.SerializeObject(pay));

                string res = webClient.DownloadString("https://localhost:44307/Buyer/CartDeletebyId/" + Session["id"].ToString());
                return "ok";
            }

        }
        //all order detailss
        public ActionResult OrderDetails()
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:/");
                    string str = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + Session["token"].ToString());


                    var res = webClient.DownloadString("https://localhost:44307/Buyer/OrderDetails/" + Session["id"]);
                    var list = JsonConvert.DeserializeObject<List<CartDetails>>(res);
                    return View(list);
                }
            }catch(Exception e)
            {
                throw new Exception();
            }

        }

    }




    

}