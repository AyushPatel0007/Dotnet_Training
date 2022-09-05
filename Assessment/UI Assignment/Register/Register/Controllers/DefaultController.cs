using Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Register.Controllers
{

    public class DefaultController : ApiController
    {

        ComContext db = new ComContext();

        [HttpGet]
        [Route("InsertData")]
        public string InsertData(User s)
        {
            User u = new User()
            {
                UserName = "ds",
                Email = "rs",
                Password = "fgsd",
                Cpassword = "fgsd",
                City = "rgsert"
            };

            db.Users.Add(u);
            db.SaveChanges();
            int i = db.SaveChanges();
            if (i > 0)
                return "success";
            else
                return "not success";

        }


       


       
    }
}
