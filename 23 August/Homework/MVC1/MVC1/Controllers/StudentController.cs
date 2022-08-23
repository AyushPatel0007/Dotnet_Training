using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //var res = new Student() { Sname="ahiug"};
            //// ViewData["Result"] = res;
            //// ViewBag.Result = res;
            //var vw = new ViewResult();
            //vw.ViewData.Model=res;
            return View();

        }
       // [Route("Student/Admission/{name}/{id:regex(\\d{2}):range(1,14)}")]
        public ActionResult GetDetail(string name,int id)
        {
            return Content(name + "/" + id);
        }
        public ActionResult GetAllData()
        {
            var str = Studen();
            return View(str);
        }
        public ActionResult GetByid(int i)
        {
            var str = Studen().Where(x => x.Sid == i).FirstOrDefault();
            return View(str);
        }

        private List<Student> Studen()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student()
            {
                Sid = 1,
                Sname = "ayush"

            }) ;
            lst.Add(new Student()
            {
                Sid = 2,
                Sname = "lucky"

            });
            return lst;

        }

    }
}