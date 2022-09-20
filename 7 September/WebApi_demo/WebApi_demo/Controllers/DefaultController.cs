using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
 using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using WebApi_demo.Models;
using WebApi_demo.Repository;

namespace WebApi_demo.Controllers
{
    public class DefaultController : ApiController
    {
        UserManagementEntities db = new UserManagementEntities();
       private IUserRepository _userrepository;
        public DefaultController(IUserRepository userrepository)
        {
            _userrepository = userrepository;
        }

        [Route("GetAllUser")]
        [HttpGet]
        public List<UserDetail> GetAllUser()
        {
            return _userrepository.GetAllUser().ToList();
        }


        [Authorize(Roles = "Admin,User")]

        [Route("Userdetail")]
        [HttpGet]
        public UserDetail Userdetail(string username)
        {
            return _userrepository.Userdetail(username);
        }

        [Route("UsernameAvailable")]
        [HttpGet]
        public bool UsernameAvailable(string username)
        {
            var res=db.UserDetails.FirstOrDefault(x => x.UserName == username);
            if (res == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }






        [Route("OnlyAdmin")]
        [HttpGet]
        public string onlyAdmin()
        {
            return "Admin view"+User.Identity.Name;
        }

        [HttpGet]
        [Route("OnlyUser")]
        [Authorize(Roles = "User")]

        public string onlyUser()
        {
            return "UserView"+User.Identity.Name;
        }

        [HttpPost]
        [Route("Register")]
        public int Register(UserDetail d)
        {
   
            db.UserDetails.Add(d);
            return db.SaveChanges();
        }

        [HttpPost]
        [Route("Registers")]
        public int Registers([FromBody]JToken val)
        {

            var d = JsonConvert.DeserializeObject<UserDetail>(val.ToString());
            db.UserDetails.Add(d);

            return db.SaveChanges();
        }


        [HttpGet]
        [Route("GetUserDetail/{username}")]
        public UserDetail GetUserDetail(string username)
        {
            
            return db.UserDetails.FirstOrDefault(x=>x.UserName==username);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public string Delete(int id)
        {

            var res= db.UserDetails.FirstOrDefault(x => x.Id == id);
            if (res!= null)
            {
                //throw new HttpResponseException(HttpStatusCode.BadRequest);

                //second way
                //var msg = new HttpResponseMessage(HttpStatusCode.NotFound)
                //{
                //    Content = new StringContent(string.Format("Your search id  is not found")),
                //    ReasonPhrase = "Error not founf"
                //};
                //throw new HttpResponseException(msg);
            }
            //db.UserDetails.Remove(res);
            //db.SaveChanges();
            return "SUCESS full";
        }






        [HttpPost]
        [Route("SubmitData")]
        public int SubmitData(UserDetail d)
        {


            //if (d.ImageUpload != null)
            //{
            //    string filename = Path.GetFileNameWithoutExtension(d.ImageUpload.FileName);
            //    string extension = Path.GetExtension(d.ImageUpload.FileName);
            //    filename = filename + DateTime.Now.ToString("yymmssff") + extension;
            //    d.Email = "~/Images/" + filename;
            //    var path = System.Web.Hosting.HostingEnvironment.MapPath("~/Images");
            //    var fullpath = Path.Combine(path, filename);
            //    d.ImageUpload.SaveAs(fullpath);

            //}
            db.UserDetails.Add(d);
            return db.SaveChanges();
        }


    }
}
