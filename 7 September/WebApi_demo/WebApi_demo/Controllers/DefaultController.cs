using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_demo.Models;

namespace WebApi_demo.Controllers
{
    public class DefaultController : ApiController
    {
        UserManagementEntities db = new UserManagementEntities();
        OAuthAuthorizationServerProvider token = new OAuthAuthorizationServerProvider();








        [Authorize(Roles = "Admin")]
        [Route("OnlyAdmin")]
        [HttpGet]
        public string onlyAdmin()
        {
            return User.Identity.Name;
        }

        [HttpGet]
        [Route("OnlyUser")]
        [Authorize(Roles = "User")]

        public string onlyUser()
        {
            return User.Identity.Name;
        }

        //[HttpGet]
        //[Route("Gettoken")]
        //public string Gettoken(string username, string password)
        //{
        //    UserModel u = new UserModel();
        //    var res = u.ValidateUser(username, password);
        //    if()
        //    return User.Identity.Name;
        //}



    }
}
