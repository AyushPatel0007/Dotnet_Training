using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StudentDetail()
        {
            var stu = new Student() { Sid = 1, Sname = "Ayush", Semail = "ayu@gmail.com", Spassword = "fxgc", Departments_Did = 122 };
            //return Content("Here is text to display");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "home", new { page = 1, sortby = "asc" });
            return View(stu);
        }
        public string Parameter(int? id)//? nullable parameter
        {
            return "hi " + id;
        }
        public ActionResult Index()
        {
            TempData["result"] = "cgfchvj vjhfu";

            //helper tag
            return View();
        }

        public ActionResult About()
        {
            //viewbag is slower and viewdata is faster
            ViewData["myList"] = new String[] { "ayush", "lukvy", "kann" };
            return View(ViewData["myList"]);
        }

        public ActionResult Contact()
        {

            //temp[data] only for session
            ViewBag.Result = TempData["result"];
            return View();
        }
    }
}