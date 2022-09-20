using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shopping_Website_UI.Customer_Filter
{
    public class SessionFilter : FilterAttribute, IActionFilter
    {
       

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ctx = filterContext.HttpContext;

            //if Session == null => Login page
            if (ctx.Session["username"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "Register", controller = "Home" }));

            }

         }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Message="Action Execeuting";
        }
    }
}