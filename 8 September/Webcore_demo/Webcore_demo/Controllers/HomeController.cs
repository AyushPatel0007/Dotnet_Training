using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webcore_demo.Models;
using Webcore_demo.Repo;

namespace Webcore_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private readonly IEmployeeRepo _emp;
         public HomeController(ILogger<HomeController> logger, IEmployeeRepo emp)
        {
            _logger = logger;
             _emp=emp;
         }

        public IActionResult Index()
        {
            
            return View(_emp.Getdata().ToList());
        }
        [HttpGet]
        public IActionResult AddData()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddData(UserDetail u)
        {
            _emp.AddData(u);
            return RedirectToAction("Index");
        }


        public IActionResult Getbyid(int id)
        {

            return View(_emp.Getbyid(id));
        }
        public IActionResult Delete(int id)
        {
            _emp.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
           var res= _emp.Getbyid(id);
            return View(res);
            
        }

        [HttpPost]
        public IActionResult Edit(UserDetail u)
        {
             _emp.Update(u);
            return RedirectToAction("Index");


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
