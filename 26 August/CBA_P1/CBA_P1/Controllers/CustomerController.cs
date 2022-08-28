using CBA_P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBA_P1.Controllers
{
    public class CustomerController : Controller
    {
        ComContext db = new ComContext();

        // GET: Customer
        [Authorize]
        public ActionResult ViewCustomer()
        {
            return View(db.Customers.ToList());
        }
    }
}