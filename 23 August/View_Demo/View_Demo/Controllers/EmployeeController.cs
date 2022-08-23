using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Demo.Models;


namespace View_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        //GET: Employee
        public ActionResult GetAllData()
        {
            ViewData["r"] = new EmployeeBusinessLayer().GetAllDetail().ToList();
            return View();
        }

        public ActionResult GetAllData1()
        {
            ViewBag.r = new EmployeeBusinessLayer().GetAllDetail().Where(x => x.Empid == 1);
            return View();
        }
    }
}