using Newtonsoft.Json;
using Student_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Student_UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
      
        public ActionResult InsertData()
        {
            return View();

        }
        [HttpPost]
        //Insert Data
        public ActionResult InsertData(StudentModel st)
        {
            if (ModelState.IsValid)
            {
                using (WebClient webclient = new WebClient())
                {
                    webclient.Headers.Add("Content-type:application/json");
                    webclient.Headers.Add("Accept:application/json");
                    string response = webclient.UploadString("https://localhost:44349/InsertData", JsonConvert.SerializeObject(st));
                    return RedirectToAction("StudentsData");
                }
            }
            else
            {
                return View();
            }

        }
         
        //Get All the data 
        public ActionResult StudentsData()
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44349/GetAllStudent");
                var res = JsonConvert.DeserializeObject<IList<StudentModel>>(response);
                return View(res);
            }

        }
        //Get the data by id
        public ActionResult StudentData(int id)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44349/GetStudent/" + id.ToString());
                var res = JsonConvert.DeserializeObject<StudentModel>(response);
                return View(res);
            }

        }
        //delete the data by id
        public ActionResult DeleteStudent(int id)
        {
            using (WebClient webclient = new WebClient())
            { 
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44349/DeleteStudent/"+id.ToString()) ;
                return RedirectToAction("StudentsData");
            }

        }

        public ActionResult EditData(int id)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44349/GetStudent/" + id.ToString());
                var res = JsonConvert.DeserializeObject<StudentModel>(response);
                return View(res);
            }

        }
        [HttpPost]
        //update the data
        public ActionResult EditData(StudentModel st)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.UploadString("https://localhost:44349/UpdateStudent","PUT",JsonConvert.SerializeObject(st));
                return RedirectToAction("StudentsData");
            }

        }



    }
}