using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_UI.ExceptionClass
{
    public class CheckException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(filterContext.Exception is CustomException k)
            {

                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;

            }
        }
    }
}