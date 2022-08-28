using CBA_P2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBA_P2.Controllers
{
    public class HomeController : Controller
    {
        ComContext db = new ComContext();
        DateTime date1 = new DateTime(2015, 12, 25);
        public ActionResult Index()
        {
            Product p = new Product()
            {
                Pid = 1, Pname = "njbk", Price = 234,Purchase=date1
            };
            db.Products.Add(p);
            db.SaveChanges();
            return View();
        }
        [AllowAnonymous]
        //[Authorize]
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