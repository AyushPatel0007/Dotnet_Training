using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_Annotation.Models;

namespace Model_Annotation.Controllers
{
    public class StduentController : Controller
    {
        DBEntities db = new DBEntities();
        // GET: Stduent
        public ActionResult StudentList()
        {
            var res = db.Database.SqlQuery<Student>("SelectStudent");
            return View(res);
        }

        public ActionResult StudentData()
        {
            var res = db.Database.SqlQuery<Student>("SelectStudent");
            return View(res);
        }
    }
}