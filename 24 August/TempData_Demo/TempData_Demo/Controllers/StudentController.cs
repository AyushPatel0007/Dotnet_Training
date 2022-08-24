 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TempData_Demo.Models;
namespace TempData_Demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> st = new List<Student>() {
               new Student(){Id=1,Name="Ayush",Email="ayu"},
               new Student(){Id=2,Name="Ayush2",Email="ayu2"},
               new Student(){Id=3,Name="Ayush3",Email="ayu3" }
            };
            Employee e = new Employee() { EmpName = "ayush" };
            dynamic model = new System.Dynamic.ExpandoObject();
            model.Student = st;
            model.Employee = e;
            return View(model);
        }
        public PartialViewResult About()
        {
            List<Student> st = new List<Student>() {
               new Student(){Id=1,Name="Ayush",Email="ayu"},
               new Student(){Id=2,Name="Ayush2",Email="ayu2"},
               new Student(){Id=3,Name="Ayush3",Email="ayu3" },
               new Student(){Id=4,Name="Ayush4",Email="ayu4" }

            };
            Employee e = new Employee() { EmpName = "ayush" };
            dynamic model = new System.Dynamic.ExpandoObject();
            model.Student = st;
            model.Employee = e;
            return PartialView(model);
        }



        public ContentResult ContentDemo()
        {
            return Content("<b>hello<b>");
        }

        public RedirectResult redirectResultDemo()
        {
            return Redirect("https://google.com");
        }

        public FileResult ShowDemo()
        {
            return File("~/Content/Site.css", "text/plain");
        }

        public FileResult DownloadDemo()
        {
            return File("~/Content/Site.css", "text/plain","Mvc.css");
        }

        public ActionResult HttpDemo()
        {
            var res= new HttpStatusCodeResult(200);
            return res;
        }

    }
}