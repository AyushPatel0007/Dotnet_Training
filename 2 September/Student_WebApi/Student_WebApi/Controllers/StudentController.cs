using Microsoft.AspNetCore.Cors;
using Student_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Student_WebApi.Controllers
{
    [AllowCrossSiteJson]
    public class StudentController : ApiController
    {
        ComContext db = new ComContext();

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("InsertData")]
        [EnableCors("AllowOrigin")]

        public string InsertStudent(StudentModel st)
        {
            db.Configuration.ProxyCreationEnabled = false;
            School s = new School() { Sid = 1, Name = "jh" };
            db.Schools.Add(s);
            db.SaveChanges();



            db.StudentModels.Add(st);
            int i=db.SaveChanges();
            if(i>0)
            return "success";
            else
            return "not success";

        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetAllStudent")]
        public List<StudentModel> GetAllStudent()
        {
            return db.StudentModels.ToList();
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("AjaxAllStudent")]
        [EnableCors("AllowOrigin")]
        public List<StudentModel> AjaxAllStudent()
        {
            db.Configuration.ProxyCreationEnabled = false;

            return db.StudentModels.ToList();
        }
 

        //[HttpGet]
        //[Route("GetStudent/{id}")]
        //public StudentModel GetStudent(int id)
        //{
        //    return db.StudentModels.FirstOrDefault(x=>x.Id==id);
        //}

        //[HttpGet]
        //[Route("DeleteStudent/{id}")]
        //public string DeleteStudent(int id)
        //{
        //    var res= db.StudentModels.FirstOrDefault(x => x.Id == id);
        //    db.StudentModels.Remove(res);
        //    int i = db.SaveChanges();
        //    if (i > 0)
        //        return "success";
        //    else
        //        return "not success";
        //}

        //[HttpPut]
        //[Route("UpdateStudent")]
        //public string UpdateStudent(StudentModel st)
        //{
        //    var res = db.StudentModels.FirstOrDefault(x => x.Id == st.Id);
        //    res.Name = st.Name;
        //    res.Email = st.Email;
        //    res.Password = st.Password;

        //     int i = db.SaveChanges();
        //    if (i > 0)
        //        return "success";
        //    else
        //        return "not success";
        //}
    }
}
