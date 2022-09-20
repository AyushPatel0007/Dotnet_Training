using Newtonsoft.Json;
using Shopping_Website_UI.Customer_Filter;
using Shopping_Website_UI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Shopping_Website_UI.Controllers
{
    [SessionFilter]
    [HandleError]
    public class SellerController : Controller
    {
        // GET: Seller
        //Index
            //Show all the added product
        public ActionResult ShowData()
        {
            try
            {
                 using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Contet-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    string token = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + token);

                    string res = webClient.DownloadString("https://localhost:44307/Seller/DisplayData/" + Session["id"].ToString());
                    var list = JsonConvert.DeserializeObject<List<ProductDetail>>(res);
                    return View(list);
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid Action Performed");
            }
        }
         
        // GET: Insert
        public ActionResult InsertProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertProduct(ProductDetail sp, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers.Add("Content-type:application/Json");
                        webClient.Headers.Add("Accept:application/Json");
                        //sp.Sellerid = Convert.ToInt32(Session["id"]);

                        string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                        string extension = Path.GetExtension(ImageFile.FileName);
                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        DateTime now = DateTime.Now;
                        sp.Publish = now;

                        if (extension.ToLower() == ".png" || extension.ToLower() == ".jpg")
                        {
                            Stream ImageFile1 = ImageFile.InputStream;
                            using (var image = System.Drawing.Image.FromStream(ImageFile1))
                            {
                                int newWidth = 612; // New Width of Image in Pixel  
                                int newHeight = 612; // New Height of Image in Pixel  
                                var thumbImg = new Bitmap(newWidth, newHeight);
                                var thumbGraph = Graphics.FromImage(thumbImg);
                                thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
                                thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
                                thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                var imgRectangle = new Rectangle(0, 0, newWidth, newHeight);
                                thumbGraph.DrawImage(image, imgRectangle);
                                sp.Imageurl = "/Image/" + fileName;
                                fileName = Path.Combine(Server.MapPath("~/Image/" + fileName));
                                thumbImg.Save(fileName);
                            }
                            sp.Sellerid = Convert.ToInt32(Session["id"]);
                            string token = Session["token"].ToString();
                            webClient.Headers.Add("Authorization:Bearer " + token);
                            webClient.UploadString("https://localhost:44307/Seller/InsertData", JsonConvert.SerializeObject(sp));
                        }

                    }
                }
                catch (Exception)
                {
                    throw new Exception("Invalid Action Performed");
                }
            }
            else
            {
                return View();
            }

            return RedirectToAction("ShowData");
        }

        //update product data
        [HttpGet]
        public ActionResult UpdateData(int id)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    string token = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + token);
                    string res = webClient.DownloadString("https://localhost:44307/Seller/SelectData/" + id.ToString());
                    return View(JsonConvert.DeserializeObject<ProductDetail>(res));
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid Action Performed");
            }


        }

        [HttpPost]
        public ActionResult UpdateData(ProductDetail pro, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                using (WebClient webClient = new WebClient())
                {
                    pro.Sellerid = Convert.ToInt32(Session["id"]);
                    DateTime now = DateTime.Now;
                    pro.Publish = now;
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    if (ImageFile != null)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                        string extension = Path.GetExtension(ImageFile.FileName);
                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;


                        if (extension.ToLower() == ".png" || extension.ToLower() == ".jpg")
                        {
                            Stream ImageFile1 = ImageFile.InputStream;
                            using (var image = System.Drawing.Image.FromStream(ImageFile1))
                            {

                                int newWidth = 612; // New Width of Image in Pixel  
                                int newHeight = 612; // New Height of Image in Pixel  
                                var thumbImg = new Bitmap(newWidth, newHeight);
                                var thumbGraph = Graphics.FromImage(thumbImg);
                                thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
                                thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
                                thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                var imgRectangle = new Rectangle(0, 0, newWidth, newHeight);
                                thumbGraph.DrawImage(image, imgRectangle);
                                pro.Imageurl = "/Image/" + fileName;
                                fileName = Path.Combine(Server.MapPath("~/Image/" + fileName));
                                thumbImg.Save(fileName);
                            }
                        }

                        
                    }
                    string token = Session["token"].ToString();
                    webClient.Headers.Add("Authorization:Bearer " + token);
                    webClient.UploadString("https://localhost:44307/Seller/UpdateData", "PUT", JsonConvert.SerializeObject(pro));
                    return RedirectToAction("ShowData");
                }
            }
            else
            {
                TempData["Update product"] = "Invalid Input Field";
                return View();
            }


        }



        //profile view

        public ActionResult Profile()
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



        //update profile
        [HttpPost]
        public ActionResult EditProfile(UserDetails std)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (WebClient webClient = new WebClient())

                    {
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

    }
}