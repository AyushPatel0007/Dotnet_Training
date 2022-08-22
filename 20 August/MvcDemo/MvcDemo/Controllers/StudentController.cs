using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public String Index1(string Name,string s)
        {
            return "welcome" + Name+" <br>"+ s;
        }
        public String Connect(int a,int b)
        {
            return "welcome "+(a + b);
        }


    }
}