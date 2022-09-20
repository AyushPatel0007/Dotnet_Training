using Image.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Image.Controllers
{
    public class HomeController : Controller
    {
        DbEntities db=new DbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            HttpCookie httpcookie = new HttpCookie("Global");//persistant cookie
            httpcookie.Expires = DateTime.Now.AddDays(1);
            httpcookie["shop"] = "Adidas";
            Response.Cookies.Add(httpcookie);


             return View();
           
        }
        [HttpPost]
        public ActionResult Login(Student stu)
        {
            bool isValid = db.Students.Any(x => x.Semail == stu.Semail && x.Spassword == stu.Spassword);
            if (isValid)
            {
                FormsAuthentication.SetAuthCookie(stu.Semail, false);
                return RedirectToAction("ImagesView", "Student");
            }
            else
            {
                return View();
            }

           
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
























        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}