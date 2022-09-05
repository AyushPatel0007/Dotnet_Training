using Api_Practise_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Practise_.Controllers
{
    public class DefaultController : ApiController
    {
        ComContext db = new ComContext();

        [HttpGet]
        [Route("DisplayData")]
        public List<Department> DisplayData()
        {
            return db.Departments.ToList();
        }



        [HttpPost]
        [Route("InsertData")]
        public void InsertData(Department dept)
        {
            db.Departments.Add(dept);
            db.SaveChanges();
        }

        [HttpGet]
        [Route("DeleteData/{id}")]
        public void DeleteData(int id)
        {
            var res = db.Departments.FirstOrDefault(x => x.Id == id);
            db.Departments.Remove(res);
            db.SaveChanges();
         }

        [HttpGet]
        [Route("SelectData/{id}")]
        public Department DelmbkjbgjkData(int id)
        {
            var res = db.Departments.FirstOrDefault(x => x.Id == id);
            return res;
        }

        [HttpPut]
        [Route("UpdateData")]
        public void DelmbkjbgjkData(Department dept)
        {
            var res = db.Departments.FirstOrDefault(x => x.Id == dept.Id);
            res.Name = dept.Name;
            res.Email = dept.Email;
            res.Password = dept.Password;
            db.SaveChanges();
            
        }

    }
}
