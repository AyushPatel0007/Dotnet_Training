using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi_UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UDashboard()
        {
            return View();
        }
    }
}