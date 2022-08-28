using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.Models;

namespace Image.Controllers
{
    
    public class StudentController : Controller
    {
        // GET: Student
        DbEntities db = new DbEntities();
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
         public ActionResult Add(Student stu)
        {
           
            Student st = new Student();
            string filename = Path.GetFileNameWithoutExtension(stu.ImageFile.FileName);
            string Extension = Path.GetExtension(stu.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + Extension;
            stu.Semail = "~/Images/" + filename;
            st.Semail = stu.Semail;
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            stu.ImageFile.SaveAs(filename);
            db.Students.Add(stu);
            db.SaveChanges();
            return View();
        }

        [Authorize]
        public ActionResult ImagesView()
        {

            var res = db.Students.ToList();
            return View(res);
        }

        public ActionResult Add1()
        {

           
            return View();
        }



    }
}