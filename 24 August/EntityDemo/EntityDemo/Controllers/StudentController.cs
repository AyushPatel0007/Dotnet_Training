using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityDemo.Models;

namespace EntityDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        DbEntities db = new DbEntities();

        public ActionResult Display()
        {
            List<Student> res = db.Students.ToList();
            return View(res);
        }

        public ActionResult DisplayById(int id)
        {
            var res = db.Students.FirstOrDefault(x=>x.Sid==id);

            return View(res);
        }

        public ActionResult RegisterForm(Student stu)
        {
            if (stu!=null)
            {
 
                return View(stu);
            }
            else
            {
                 return View();
            }
          
        }
        [HttpPost]
        public ActionResult Insert(Student stu)
        {
            Student st = new Student();
            st.Sname = stu.Sname;
            st.Semail = stu.Semail;
            st.Spassword = stu.Spassword;
            st.Departments_Did = stu.Departments_Did;
            var res = db.Students.Where(x => x.Sid == stu.Sid).FirstOrDefault();

            if (res == null)
            {

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
            List<Student> ress = db.Students.ToList();

            return View("Display",ress);
        }

        public ActionResult Delete(int id)
        {
            var res = db.Students.FirstOrDefault(x => x.Sid == id);
            db.Students.Remove(res);
            db.SaveChanges();
            List<Student> ress = db.Students.ToList();
            return View("Display", ress);
        }
    }
}