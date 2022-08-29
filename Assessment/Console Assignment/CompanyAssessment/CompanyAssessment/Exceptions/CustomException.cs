using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyAssessment.Exceptions
{
    public class CustomException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is MyException1 m)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                MyException1 custException = new MyException1(m.msg1);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),

                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;
            }
            else if (filterContext.Exception is Foreignkey fk)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                Foreignkey custException = new Foreignkey(fk.msg1);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),

                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;
            }
            else if (filterContext.Exception is NullDataFound nk)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                NullDataFound custException = new NullDataFound(nk.msg1);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),

                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;
            }
            else if (filterContext.Exception is WrongInput nnk)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                WrongInput custException = new WrongInput(nnk.msg1);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),

                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}