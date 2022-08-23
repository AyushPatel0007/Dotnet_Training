using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVC_Get_POst.Models;


namespace MVC_Get_POst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }





        [HttpPost]
        public ActionResult Submit(Student stu)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
                return View("Index");
         }
















        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //using parameter
        //public string GetRegister(string first,string second)
        //{
        //    return first + " " + second;
        //}

        //using request
        //public string GetRegister()
        //{
        //    string first = Request["first"];
        //    string second = Request["second"];
        //    return first + " " + second;
        //}

        //using Formcollection
        //public string GetRegister(FormCollection form)
        //{
        //    string first = form["first"];
        //    string second = form["second"];
        //    return first + " " + second;
        //}


        //using Class
        public string GetRegister(Student stu)
        { 
            return stu.id + " " + stu.Name+" "+stu.Address;
        }





















        [Route("students")]
        public ActionResult GetAllStudent()
        {
            var student = GetData();
            return View(student);
        }
        public ActionResult GetById()
        {
            var res = GetData().Where(x => x.id == 2).SingleOrDefault();
            return View(res);
         }
        public ActionResult GetAddress()
        {
            return View();
        }

        private List<Student> GetData()
        {
            List<Student> lst = new List<Student>()
            {
                new Student(){id=1,Name="ayush",Address="hgcg"
                },
                new Student(){id=2,Name="ayush2",Address="hgc1g"
                },
                new Student(){id=3,Name="ayus3",Address="hg2cg"
                }
            };
            return lst;
        }
    }
}