using CBA_P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CBA_P1.Controllers
{
    public class HomeController : Controller
    {
        ComContext db = new ComContext();
        DateTime date1 = new DateTime(2015, 12, 25);
        public ActionResult Index()
        {
            //Customer su = new Customer()
            //{
            //    Cid = 1, Cname = "Aysh", Caddress = "gc", Product = new Product()
            //    {
            //        Pid = 1, Pname = "ihf", Price = 123, Purchase = date1 
            //    }
            //};
            //db.Customers.Add(su);
            //db.SaveChanges();
            return View();
        }

        public ActionResult AddProduct()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges();
            return View();
        }
        public ActionResult ShowProducts()
        {
            var res=db.Products.ToList();
            db.SaveChanges();
            return View(res);
        }

        public ActionResult AddCustomer()
        {
 
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();

            return RedirectToAction("Login");
        }
        public ActionResult ShowCustomer()
        {
            var res=db.Customers.ToList(); 
            return View(res);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer st)
        {
            bool res = db.Customers.Any(x=>x.Cname==st.Cname&&x.Products_Pid==st.Products_Pid);
            if (res && st!=null)
            {
                FormsAuthentication.SetAuthCookie(st.Cname, false);
                return RedirectToAction("ViewCustomer", "Customer");

            }
            else
            {
                return View();
            }
         }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}