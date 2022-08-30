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
        // GET: Shop
        ShopDb db = new ShopDb();
        public ActionResult InsertProduct()
        {
             
            return View();
        }
        [HttpPost]
        public ActionResult InsertProduct(Product p)
        {
            db.Database.ExecuteSqlCommand("exec InsertProduct @n='"+p.Name+"',@p='"+p.Price+"',@cid='"+p.Categories_Cid+"'");
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
            db.Database.ExecuteSqlCommand("exec InsertCategory @n='" + p.Cname + "'");
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
            db.Database.ExecuteSqlCommand("exec DeleteProduct @id='"+id+"'");
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
            db.Database.ExecuteSqlCommand("exec UpdateProduct @id='"+p.Pid+"',@n='" + p.Name + "',@p='" + p.Price + "',@cid='" + p.Categories_Cid + "'");
            return RedirectToAction("ViewProducts", "Shop");
        }

        

        public ActionResult ProductDetail(int id)
        {
           ViewBag.r= db.Database.SqlQuery<ViewAll>("exec viewall");
            return View();
        }
    }
}