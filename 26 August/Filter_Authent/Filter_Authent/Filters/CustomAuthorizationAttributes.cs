using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Authent.Filters
{
    public class CustomAuthorizationAttributes : FilterAttribute, IAuthorizationFilter
    {
        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.OnAuthorization = "IActionAuthorization  OnAuthorization called";
        }
    }
}