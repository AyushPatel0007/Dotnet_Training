using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDemo.Context;
 

namespace EntityFrameworkDemo.Controllers
{
    public class StudentController : Controller
    {
        DbEntities db = new DbEntities();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StudentForm(Student stu)
        {
            if (stu != null)
                return View(stu);
            else
                return View();
        }
        [HttpPost]
        public string Register(Student stu)
        {
            Student st = new Student();
            st.Sname = stu.Sname;
            st.Semail = stu.Semail;
            st.Spassword = stu.Spassword;
            st.Departments_Did = stu.Departments_Did;
            var res = db.Students.Where(x => x.Sid == stu.Sid).FirstOrDefault();

            if (res ==null) { 
            
                    db.Students.Add(st);
                    db.SaveChanges();
            }
            else
            {
                res.Sname = stu.Sname;
                res.Semail = stu.Semail;
                res.Spassword = stu.Spassword;
                res.Departments_Did = stu.Departments_Did;
                db.SaveChanges();
            }
            return "Added Successfull";
        }

        public ActionResult StudentList()
        {
            var res = db.Students.ToList();
            return View(res);
        }

        public ActionResult Delete(Int32 Sid)
        {
            var res = db.Students.Where(x=>x.Sid==Sid).FirstOrDefault();
            db.Students.Remove(res);
            db.SaveChanges();
            var ress = db.Students.ToList();
            return View("StudentList",ress);
        }

    }
}