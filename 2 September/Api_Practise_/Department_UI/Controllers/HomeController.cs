using Department_UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Department_UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string res = webclient.DownloadString("https://localhost:44306/DisplayData");
                var list = JsonConvert.DeserializeObject<List<Department1>>(res);
                return View(list);
            }

        }
        public ActionResult InsertData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertData(Department1 dept)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                webclient.UploadString("https://localhost:44306/InsertData", JsonConvert.SerializeObject(dept));
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                webclient.DownloadString("https://localhost:44306/DeleteData/"+id.ToString());
                return RedirectToAction("Index");
            }
        }

        public ActionResult UpdateData(int id)
        {

            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                var res=webclient.DownloadString("https://localhost:44306/SelectData/"+id.ToString());
                return View(JsonConvert.DeserializeObject<Department1>(res));
            }

        }

        public ActionResult Details(int id)
        {

            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                var res = webclient.DownloadString("https://localhost:44306/SelectData/" + id.ToString());
                return View(JsonConvert.DeserializeObject<Department1>(res));
            }

        }

        [HttpPost]
        public ActionResult UpdateData(Department1 dept)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                webclient.UploadString("https://localhost:44306/UpdateData","PUT", JsonConvert.SerializeObject(dept));
                return RedirectToAction("Index");
            }
        }
    }
}