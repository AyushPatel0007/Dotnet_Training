using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Authent.Filters
{
    public class CustomActionAttribute :   ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string Cname = filterContext.RouteData.Values["controller"].ToString();
            string Aname= filterContext.RouteData.Values["action"].ToString();
            HttpContext.Current.Response.Write($"MethodName=OnActionExecuting,Controller={Cname},Action={Aname}");
        }
        
         
    }
}