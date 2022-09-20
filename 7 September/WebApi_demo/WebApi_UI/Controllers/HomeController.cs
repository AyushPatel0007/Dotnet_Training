using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi_UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            Session["value"] = "login vaue";
            ViewBag.r = "jgcnhgf";
            return View();
        }
        public ActionResult Upload()
        {
            return View();
        }
       


    }
}