using Shop_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_Assessment.Controllers
{
    public class ShopController : Controller
    {
        public ActionResult Index(int i)
        {
            if (i == 0)
                return View("Index");
            else
                return View("Index2");
        }
        public ActionResult Index2()
        {
            ViewData["Some"] = "Somevalue";
            return View("Index2");
        }
        // GET: Shop
        ShopDb db = new ShopDb();
        public ActionResult InsertProduct()
        {
             
            return View();
        }
        [HttpPost]
        public ActionResult InsertProduct(Product p)
        {
            db.Database.ExecuteSqlCommand("exec sp_InsertProduct @name='"+p.Name+"',@price='"+p.Price+"',@cid='"+p.Categories_Cid+"'");
            db.SaveChanges();
            return RedirectToAction("ViewProducts", "Shop");
        }

        public ActionResult InsertCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult InsertCategory(Category p)
        {
            db.Database.ExecuteSqlCommand("exec sp_InsertCategory @name='" + p.Cname + "'");
            db.SaveChanges();
            return RedirectToAction("ViewProducts", "Shop");
        }

        public ActionResult ViewProducts()
        {
            var res = db.Database.SqlQuery<Product>("exec SelectProduct").ToList();
            return View(res);
        }

        public ActionResult DeleteProducts(int id)
        {
            db.Database.ExecuteSqlCommand("exec sp_DeleteProduct @Id='"+id+"'");
            db.SaveChanges();
            return  RedirectToAction("ViewProducts","Shop");
        }

        public ActionResult UpdateProducts(int id)
        {

            var res = db.Products.FirstOrDefault(x => x.Pid==id);
            return View(res);
        }


        [HttpPost]
        public ActionResult UpdateProducts(Product p)
        {
            db.Database.ExecuteSqlCommand("exec sp_UpdateProduct @Pid='"+p.Pid+"',@name='" + p.Name + "',@price='" + p.Price + "',@cid='" + p.Categories_Cid + "'");
            return RedirectToAction("ViewProducts", "Shop");
        }

        

        public ActionResult ProductDetail(int id)
        {
           ViewBag.r= db.Database.SqlQuery<ViewAll>("exec viewall");
            return View();
        }
    }
}