using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helper_Tag.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult UpdateData()
        {
            return View();
        }

        public string  Getdata()
        {
            string name = Request["Name"];
            string email = Request["Email"];
            string gender = Request["Gender"];
            var res = Request["Training"].ToList();
            string skill = Request["Skills"];
            ViewBag.r = res;


            return "Name is: "+name+"<br><h3>Result Submitted!!!!</h3>";
        }
    }
}