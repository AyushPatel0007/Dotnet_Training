using Filter_Authent.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Authent.Controllers
{
    [OutputCache(Duration =10)]
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult NotFound()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [CustomActionAttribute]
        [CustomAuthorizationAttributes]
        [CustomResultAttribute]
        [CustomExceptionAttribute]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Result()
        {
            ViewBag.r = TempData["r"];
            return View();
        }


        public ActionResult Resultk()
        {
            throw new NewException();
        }
    }
}