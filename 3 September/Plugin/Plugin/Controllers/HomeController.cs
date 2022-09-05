using Plugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plugin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Create()
        {
            return "jhvvhbc";
        }

        [HttpPost]
        public string GetData(object st)
        {
            ///code for success
            return  "Submit Successfully!!!!";
        }


    }
}