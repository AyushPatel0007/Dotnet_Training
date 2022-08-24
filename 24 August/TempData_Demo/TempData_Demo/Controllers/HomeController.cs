using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["r"] = "iNDEX";
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.T = TempData.Peek("r");
             
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult About(string Name)
        {

            if (Name == null)
 
            return View();
            else
            {
                ViewBag.Message = "Your application description page "+ Name;
                return View();
            }
        }

          public ActionResult Contact()
        {
            ViewBag.T = TempData["r"];

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}