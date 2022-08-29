using CompanyAssessment.Exceptions;
using CompanyAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyAssessment.Controllers
{

    //using Collection,Exception,Stored Procedure,CBA



    public class CompanyController : Controller
    {
        // GET: Company
        ComContext db = new ComContext();

        //Company/AddEmployee

        //Company/AddDepartment
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDepartment(Department d)
        {
            if (ModelState.IsValid)
            {

                db.Database.ExecuteSqlCommand("exec InsertDepartment @n='" + d.DeptName + "'");
                ModelState.Clear();
                return View();
            }
            else
            {
                return View();
            }
        }

        //Company/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        [CustomException]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration =10)]
        public ActionResult AddEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                var res = db.Departments.FirstOrDefault(x => x.DeptId == e.Departments_DeptId);
                if (res == null)
                {
                    throw new Foreignkey("Foreign key error");
                }

                //Stored Procedure
                db.Database.ExecuteSqlCommand("exec InsertEmployee @n='" + e.Name + "',@g='" + e.Gender + "',@c='" + e.City + "',@s='" + e.Salary + "',@d='" + e.Departments_DeptId + "'");
                 db.SaveChanges();
 
            }
            else
            {
                return RedirectToAction("ViewAllEmployee", "Company");

            }
            return RedirectToAction("ViewAllEmployee", "Company");

        }

        [CustomException]
        //Company/ViewAllEmployee
        public ActionResult ViewAllEmployee()
        {

            //Collection Use
            List<Employee> res = db.Employees.ToList();
            if (res == null)
            {
                throw new NullDataFound();
            }
            return View(res);

        }

        [CustomException]
        //Company/GetEmployee

        public ActionResult GetEmployee(int id)
        {
            var res = db.Employees.FirstOrDefault(x => x.EmpId == id);
            if (res == null)
            {
                throw new NullDataFound();
            }
            return View(res);

        }
 
        [CustomException]
        //Company/DeleteEmployee

        public ActionResult DeleteEmployee(int id)
        {
            var res = db.Employees.FirstOrDefault(x => x.EmpId == id);
            if (res == null)
            {
                throw new NullDataFound();
            }

            //Stored Procedure
            db.Database.ExecuteSqlCommand("exec DeleteEmployee @id='" + id + "'");
             db.SaveChanges();
            return RedirectToAction("ViewAllEmployee", "Company");

        }


        public ActionResult UpdateEmployee(int id)
        {
            var res = db.Employees.FirstOrDefault(x => x.EmpId == id);
                
            return View(res);

        }

        [HttpPost]
        [CustomException]

        public ActionResult UpdateEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                var res = db.Employees.FirstOrDefault(x => x.EmpId == e.EmpId);
                if (res == null)
                {
                    throw new NullDataFound();

                }

                var ress = db.Departments.FirstOrDefault(x => x.DeptId == e.Departments_DeptId);
                if (ress == null)
                {

                    throw new Foreignkey("Foreign key error");

                }
                //Store Ptrocedure
                db.Database.ExecuteSqlCommand("Exec UpdateEmployee @i='" + e.EmpId + "',@n='" + e.Name + "',@g='" + e.Gender + "',@c='" + e.City + "',@s='" + e.Salary + "',@d='" + e.Departments_DeptId + "'");
                
                db.SaveChanges();
            }
            else
            {
                return RedirectToAction("ViewAllEmployee", "Company");


            }
            ModelState.Clear();


            return RedirectToAction("ViewAllEmployee", "Company");

        }

    }
}