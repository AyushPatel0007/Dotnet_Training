using Stored_Procedure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stored_Procedure.Controllers
{
    public class StudentController : Controller
    {
        DbbEntities db = new DbbEntities();

        // GET: Student
        public ActionResult StudentList()
        {

            var res = db.SelectStudent().ToList();
            return View(res);
        }

         
        public ActionResult Register(Student stu)        {
            if(stu==null)
                return View();
            else
            {
                return View(stu);
            }
        }

        [HttpPost]
        public ActionResult InsertStudent(Student stu)
        {
            if (ModelState.IsValid)
            {
                var ress = db.Students.FirstOrDefault(x => x.Sid == stu.Sid);
                if (ress == null)
                {
                    db.InsertStudent(stu.Sname, stu.Semail, stu.Spassword, stu.Departments_Did);
                }
                else
                {
                    db.UpdatebyId(stu.Sid, stu.Sname, stu.Semail, stu.Spassword, stu.Departments_Did);
                }
                var res = db.SelectStudent().ToList();
                return View("StudentList", res);
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeleteStudent(int id)
        {
            db.DeletebyId(id);
            var res = db.SelectStudent().ToList();
            return View("StudentList", res);
        }
        public ActionResult SelectStudentbyid(int id)
        {
           var res= db.SelectbyId(id).FirstOrDefault();
           return View(res);
        }


        public ActionResult RegisterDepartment(Department d)
        {
            if (d != null)
            {
                db.InsertDepartment(d.Dname);
                
            }
            return View();


        }
        public ActionResult DeleteDepartment(int id)
        {
            db.deletedeptbyid(id);
            return View("RegisterDepartment");


        }
    }
}