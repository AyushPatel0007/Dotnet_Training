using MVC_Code_Structure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Code_Structure.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       static List<EmployeeModel> lst = EmployeeModel.Empdata();
        public ActionResult Index()
        {
           
            return View(lst);
        }


        public ActionResult Delete(string name)
        {
            var res = lst.FirstOrDefault(x => x.Name == name);
            lst.Remove(res);
            return RedirectToAction("Display");
        }

        public ActionResult Details(string name)
        {
            var res = lst.FirstOrDefault(x => x.Name == name);

            return View(res);
        }



        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel em)
        {

            lst.Add(em);
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        { 
            return View(lst);
        }


        // GET: Home/Edit/5
        public ActionResult Edit(string name)
        {
            var res = lst.FirstOrDefault(x => x.Name == name);

            return View(res);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            EmployeeModel em = new EmployeeModel();
            var res = lst.FirstOrDefault(x => x.Name == emp.Name);
            res.City = emp.City;
            res.Mobile = emp.Mobile;
             return RedirectToAction("Display");

        }
        public ActionResult GroupBy()
        {
            var res=lst.GroupBy(x => x.Mobile);
            return View(res.ToList());
        }

    }
}
