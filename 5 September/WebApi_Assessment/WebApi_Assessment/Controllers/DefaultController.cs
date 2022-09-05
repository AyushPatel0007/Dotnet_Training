using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assessment.Models;

namespace WebApi_Assessment.Controllers
{
    public class DefaultController : ApiController
    {

        ComContext db = new ComContext();


        ///Insert The data For Register The student
        [HttpPost]
        [Route("InsertData")]
        public string InsertStudent(StudentModel s)
        {
             

            db.StudentModels.Add(s);
            db.SaveChanges();
            int i = db.SaveChanges();
            if (i > 0)
                return "success";
            else
                return "not success";

        }



        //Get all the detail to check the data in database
        [HttpGet]
        [Route("GetAllStudent")]
        public List<StudentModel> GetAllStudent()
        {
            return db.StudentModels.ToList();
        }
         

        //Login the database
         
        [HttpGet]
        [Route("GetLogin/{UserName}/{Password}")]
        public int GetLogin(string UserName,string Password)
        {
            var res= db.StudentModels.FirstOrDefault(x => x.UserName==UserName&&x.Password==Password);
            if (res !=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        
    }
}
