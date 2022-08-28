using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Authent.Filters
{
    public class CustomExceptionAttribute : FilterAttribute, IExceptionFilter
    {
         void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.OnException = "IExceeption Filter Executing filter called";
        }
    }
}