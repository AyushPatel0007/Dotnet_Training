using PartialView_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> lst = new List<Employee>() { 
            new Employee(){Eid=1,Name="Ayush",City="bly" },
            new Employee(){Eid=2,Name="Ayush2",City="bly2" }
            };

            return View(lst);
        }

        [OutputCache(Duration =30)]//hold time on the page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HandleError]
        public ActionResult Contact()
        {
            throw new Exception("this is mesg");
        }
    }
}