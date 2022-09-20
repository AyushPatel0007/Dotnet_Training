using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Web;
 using System.Web.Mvc;
using Webclient.Models;

namespace Webclient.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }



        [HttpPost]
        public string Register(string username, string email, string password, string role)
        {
            string str;
            using (WebClient webclient = new WebClient())
            {
                NameValueCollection obj = new NameValueCollection();
                obj.Add("UserName", username);
                obj.Add("Email", email);
                obj.Add("Password", password);
                obj.Add("Roles", role);
                webclient.Headers.Add("Accept:/");
                webclient.Headers.Add("Content-type:application/x-www-form-urlencoded");
                var res = webclient.UploadValues("https://localhost:44375/Registers", "POST", obj);
                str = Encoding.ASCII.GetString(res);


            }
            return str;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            using (WebClient webclient = new WebClient())
            {
                NameValueCollection obj = new NameValueCollection();
                obj.Add("username", username);
                obj.Add("password", password);
                obj.Add("grant_type", "password");

                webclient.Headers.Add("Content-type:application/x-www-form-urlencoded");
                webclient.Headers.Add("Accept:/");
                var res = JsonConvert.SerializeObject(obj).ToString();
                var result = webclient.UploadValues("https://localhost:44375/token", "POST", obj);

                var str = Encoding.ASCII.GetString(result);
                var token = JsonConvert.DeserializeObject<Token>(str).access_token;
                webclient.Headers.Add("Authorization:Bearer " + token);
                var das = webclient.DownloadString("https://localhost:44375/GetUserDetail/" + username);
                var userdata = JsonConvert.DeserializeObject<UserDetails>(das);
                Session["username"] = userdata.UserName;
                Session["role"] = userdata.Roles;
                Session["token"] = token;


                //var identity = new ClaimsIdentity();
                //identity.AddClaim(new Claim(ClaimTypes.Role, userdata.Roles));
                //identity.AddClaim(new Claim(ClaimTypes.Name, userdata.UserName));
                //identity.AddClaim(new Claim("Email", userdata.Email));
                //identity.AddClaim(new Claim("Secret key", "12233"));
                //Validated(identity);



            }
            return RedirectToAction("Dashboard");


        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Dashboard()
        {


            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Accept:/");
                var res = webclient.DownloadString("https://localhost:44375/GetAllUser");
                List<UserDetails> es = JsonConvert.DeserializeObject<List<UserDetails>>(res.ToString());
                return View(es);



            }

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {


            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/text");
                webclient.Headers.Add("Accept:/");
                var res = webclient.DownloadString("https://localhost:44375/Delete/" + id.ToString());
                return RedirectToAction("Dashboard");


            }

        }
        [HttpGet]
        public ActionResult SubmitData()
        {
            return View();

        }



        [HttpPost]
        public  ActionResult SubmitData(UserDetails d,HttpPostedFileBase ImageUpload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //model state error
                    //if (d.UserName.Length == 1)
                    //{
                    //    ModelState.AddModelError("UserName", "ENter");
                    //    return View(d);
                    //}




                    //throw error
                    //throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
                }
            }catch(Exception e)
            {
                ViewBag.r = "Model State error";
            }
            return View();

            d.Email = ParseCv(ImageUpload);

            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json"); 
                var res=webclient.UploadString("https://localhost:44375/SubmitData", JsonConvert.SerializeObject(d));
                return View();


            }

        }
        public string ParseCv(HttpPostedFileBase cvFile)
        {
            byte[] fileInBytes = new byte[cvFile.ContentLength];
            using (BinaryReader theReader = new BinaryReader(cvFile.InputStream))
            {
                fileInBytes = theReader.ReadBytes(cvFile.ContentLength);
            }
            string fileAsString = Convert.ToBase64String(fileInBytes);
            return fileAsString;
        }
      

    }


    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }

    }

}