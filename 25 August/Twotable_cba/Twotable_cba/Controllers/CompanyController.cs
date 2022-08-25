using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twotable_cba.Models;

namespace Twotable_cba.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CompContext db = new CompContext();

        
        public ActionResult RegisterStudent()
        {
            return View();

        }

        public ActionResult UpdateStudent(Student stu)
        {
            return View(stu);

        }

        public ActionResult RegisterDepartment()
        {
            return View();

        }
        [HttpPost]
        public ActionResult RegisterDepartment(Department dp)
        {
                db.InsertDepart(dp);
             return View("RegisterStudent");

        }

        [HttpPost]
        public ActionResult RegisterStudent(Student stu)
        {

            //var res = db.Departments.FirstOrDefault(x => x.Did == stu.Departments_Did);
            if (ModelState.IsValid)
            {

                if (db.Selectdeptid(stu.Departments_Did))
                {

                    if (db.Selectbyid(stu.Sid))
                    {
                        db.StudentAdd(stu);
                        var ress = db.Select();
                        return View("StudentList", ress);
                    }
                    else
                    {
                        db.StudentUpdate(stu);
                        var ress = db.Select();
                        return View("StudentList", ress);
                    }
                }
                else
                {
                    return RedirectToAction("RegisterDepartment");
                }

            }
            else
            {
                return RedirectToAction("RegisterDepartment");
            }

        }

        public ActionResult StudentList()
        {
            ViewBag.r = db.SelectAll();
            List<Student> res = db.Select();
            return View(res);

        }

        public ActionResult Delete(Int32 id)
        {
            db.Remove(id);
            db.SaveChanges();
            var ress = db.Select();
            return View("StudentList", ress);
         }

        }
}