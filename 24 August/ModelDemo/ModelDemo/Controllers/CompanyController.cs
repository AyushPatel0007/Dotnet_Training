using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDemo.Models;
using ModelDemo;

namespace ModelDemo.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            Student St = new Student() { Id = 1, Email = "Ayush@gmail.com", Name = "Ayush" };
            Department dt = new Department() { Did = 001, Address = "Lko" };
            Companys c = new Companys()
            {
                Student = St,
                Department = dt,
                Cid = 11,
                Cname = "Global"
            };


            return View(c);
        }
    }
}