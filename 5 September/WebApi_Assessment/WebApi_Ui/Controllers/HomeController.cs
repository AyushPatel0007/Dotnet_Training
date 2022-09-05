using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApi_Ui.Models;

namespace WebApi_Ui.Controllers
{
    public class HomeController : Controller
    {

        //Index Page
        //Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Home/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel st)
        {
            if (ModelState.IsValid)
            {
                using (WebClient webclient = new WebClient())
                {
                    webclient.Headers.Add("Content-type:application/json");
                    webclient.Headers.Add("Accept:application/json");
                    string response = webclient.UploadString("https://localhost:44329/InsertData", JsonConvert.SerializeObject(st));
                    return RedirectToAction("Login");
                }
            }
            else
            {
                return View();

            }
        }

        //Home/DisplayAllData
        [HttpGet]
        public ActionResult Display()
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44329/GetAllStudent");
                var res = JsonConvert.DeserializeObject<IList<StudentModel>>(response);
                return View(res);
            }
        }





        //Home/Login
        //To identify the user

        [HttpGet]
        public ActionResult Login()
        {
            return View();


        }
        [HttpPost]
        public ActionResult Login(StudentModel st)
        {
            using (WebClient webclient = new WebClient())
            {
                 string url=st.UserName + "/"+st.Password;//pass the email and password
                 webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44329/GetLogin/"+url);
                var res = JsonConvert.DeserializeObject<int>(response); //coner
                if (res != 0)
                {
                    return View("Dashboard");
                }
                else
                {
                    return View();

                }
            }

        }

        public ActionResult Dashboard()
        {
            return View();

        }


    }
}