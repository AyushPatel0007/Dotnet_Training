using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Authent.Filters
{
    public class CustomResultAttribute : FilterAttribute, IResultFilter
    {
        
      void IResultFilter.OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnResultExecuting = "IResultFilter  OnResultExecuting called";
        }
        void IResultFilter.OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.TempData["r"] = "IResultFilter  OnResultExecuted called";
        }

    }
}