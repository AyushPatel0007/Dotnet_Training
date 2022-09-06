using _5_september_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5_september_Task.Controllers
{
    public class DefaultController : ApiController
    {
        ComContext db = new ComContext();

        [HttpGet]
        [Route("InsertData")]
        public string InsertData()
        {
            User u = new User()
            {
                Id = 1,
                UserName = "ds",
                Email = "rs",
                Password = "fgsd",
                Cpassword = "rgsr",
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
