using StoredProcedure_CBA.Exceptions;
using StoredProcedure_CBA.Models;
using StoredProcedure_CBA.Validator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 
namespace StoredProcedure_CBA.Controllers
{
    public class HomeController : Controller
    {
        ComContext db = new ComContext();
        public ActionResult Index()
        {
            var res = db.Products.SqlQuery("[dbo].[SelectAllProduct]").ToList();
            return View(res);
        }

        public ActionResult DeleteProductbyid()
        {
            DateTime date1 = new DateTime(2015, 12, 25);
            var res=db.Database.ExecuteSqlCommand("exec DeleteProductbyid @id", new SqlParameter("@id", 1));
            return RedirectToAction("Index");
        }
        public ActionResult ProductInsert()
        {
            DateTime date1 = new DateTime(2015, 12, 25);
            var res = db.Database.ExecuteSqlCommand("exec InsertProduct @name,@price,@pur", new SqlParameter("@name", "Virat"), new SqlParameter("@price", 1234), new SqlParameter("@pur", date1));
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Register()
        {
             
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customer c)
        {
            if (ModelState.IsValid)
            {
                return View();

            }
            return View();
        }
    }
}