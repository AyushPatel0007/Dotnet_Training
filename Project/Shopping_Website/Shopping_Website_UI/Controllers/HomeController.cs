using Newtonsoft.Json;
using Shopping_Website_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Shopping_Website_UI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

       
        //Register Page
        public ActionResult Register()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:Application/json");
                webClient.Headers.Add("Accept:*/*");
                List<RoleDetail> str = JsonConvert.DeserializeObject<List<RoleDetail>>(webClient.DownloadString("https://localhost:44307/Home/GetAllRoles"));


                var list = str.Select(x => x.Name).ToList();
                ViewBag.list = list;
                return View();
            }
        }

        //register post

        [HttpPost]

        public ActionResult Register(UserDetail c)
        {

            if (ModelState.IsValid)
            {
                using (WebClient webClient = new WebClient())
                {
                    UserDetails s = new UserDetails();
                    s.Username = c.Username;
                    s.Email = c.Email;
                    s.Password = c.Password;
                    s.Address = c.Address;
                    s.Contactno = c.Contactno ?? default(int?);
                    var roledata = webClient.DownloadString("https://localhost:44307/Home/GetRolebyName/" + c.Role);
                    var role = JsonConvert.DeserializeObject<int>(roledata);
                    s.Role = role;

                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:*/*");
                    webClient.UploadString("https://localhost:44307/Home/InsertData", JsonConvert.SerializeObject(s));

                    return RedirectToAction("Login");
                }

            }
            else
            {
                return View();
            }

        }

        //remote validation function check exists name

        public JsonResult CheckUserName(string username)
        {
            using (WebClient webClient = new WebClient())
            {


                webClient.Headers.Add("Content-type:Application/json");
                webClient.Headers.Add("Accept:*/*");
                var das = webClient.DownloadString("https://localhost:44307/Home/Getalluser");
                var userdata = JsonConvert.DeserializeObject<List<UserDetail>>(das);
                return Json(!userdata.Any(x => x.Username == username), JsonRequestBehavior.AllowGet);

            }






        }
        //Register Page end

        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        //login by username and password

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    NameValueCollection obj = new NameValueCollection();
                    obj.Add("username", username);
                    obj.Add("password", password);
                    obj.Add("grant_type", "password");

                    webClient.Headers.Add("Content-type:application/x-www-form-urlencoded");
                    webClient.Headers.Add("Accept:*/*");
                    var res = JsonConvert.SerializeObject(obj).ToString();
                    string token;
                    try
                    {
                        var result = webClient.UploadValues("https://localhost:44307/token", "POST", obj);
                        var str = Encoding.ASCII.GetString(result);
                        token = JsonConvert.DeserializeObject<Token>(str).access_token;
                    }
                    catch (Exception e)
                    {
                        TempData["msg"] = "Incorrect";
                        return RedirectToAction("Login");
                    }

                    var das = webClient.DownloadString("https://localhost:44307/Home/GetUser/" + username);
                    UserDetail userdata = JsonConvert.DeserializeObject<UserDetail>(das);
                    if (das == null)
                    {
                        TempData["msg"] = "Incorrect";

                        return RedirectToAction("Login");
                    }
                    else
                    {

                        var roledata = webClient.DownloadString("https://localhost:44307/Home/GetRole/" + userdata.Role);
                        var role = JsonConvert.DeserializeObject<string>(roledata);
                        Session["username"] = userdata.Username;
                        Session["id"] = userdata.Id;
                        Session["role"] = role;
                        Session["token"] = token.ToString();
                         if (role == "seller")
                        {
                            return RedirectToAction("ShowData", "Seller");
                        }
                        else if (role == "buyer")
                        {
                            return RedirectToAction("Index", "Buyer");

                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception();
            }


            return RedirectToAction("Login");



        }

        //get roles 
        public List<RoleDetail> GetRoles()
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:Application/json");
                    webClient.Headers.Add("Accept:*/*");
                    List<RoleDetail> str = JsonConvert.DeserializeObject<List<RoleDetail>>(webClient.DownloadString("https://localhost:44307/Home/GetAllRoles"));

                    return str;
                }
            }catch(Exception e)
            {
                throw new Exception();
            }

        }


        ///remove all session
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

    }
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }

    }
}