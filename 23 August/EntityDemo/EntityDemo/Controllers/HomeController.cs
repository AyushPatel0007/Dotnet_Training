using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;
using MyAppDb.Operation;

namespace EntityDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MyService s = new MyService();


        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
       public ActionResult Create(StudentModel stu)
        {
            s.AddStudent(stu);            

            return View();
        }

    }
}