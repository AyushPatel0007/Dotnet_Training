using Student_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student_WebApi.Controllers
{
    public class StudentController : ApiController
    {
        ComContext db = new ComContext();

        [HttpPost]
        [Route("InsertData")]       
        public string InsertStudent(StudentModel st)
        {
            
            db.StudentModels.Add(st);
            int i=db.SaveChanges();
            if(i>0)
            return "success";
            else
            return "not success";

        }

        [HttpGet]
        [Route("GetAllStudent")]
        public List<StudentModel> GetAllStudent()
        {
            return db.StudentModels.ToList();
        }
 

        [HttpGet]
        [Route("GetStudent/{id}")]
        public StudentModel GetStudent(int id)
        {
            return db.StudentModels.FirstOrDefault(x=>x.Id==id);
        }

        [HttpGet]
        [Route("DeleteStudent/{id}")]
        public string DeleteStudent(int id)
        {
            var res= db.StudentModels.FirstOrDefault(x => x.Id == id);
            db.StudentModels.Remove(res);
            int i = db.SaveChanges();
            if (i > 0)
                return "success";
            else
                return "not success";
        }

        [HttpPut]
        [Route("UpdateStudent")]
        public string UpdateStudent(StudentModel st)
        {
            var res = db.StudentModels.FirstOrDefault(x => x.Id == st.Id);
            res.Name = st.Name;
            res.Email = st.Email;
            res.Password = st.Password;

             int i = db.SaveChanges();
            if (i > 0)
                return "success";
            else
                return "not success";
        }
    }
}
