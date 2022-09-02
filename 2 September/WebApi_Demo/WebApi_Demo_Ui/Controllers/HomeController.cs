 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApi_Demo_Ui.Models;
 using Newtonsoft.Json;

namespace WebApi_Demo_Ui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using(WebClient webclient=new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44333/GetAllRecharge");
                var res = JsonConvert.DeserializeObject<IList<RechargeModel>>(response);
                return View(res);
            }
            
        }

        public ActionResult Detail(int id)
        {
            string s = id.ToString();
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44333/GetDetails/"+s);
                var res = JsonConvert.DeserializeObject<RechargeModel>(response);
                return View(res);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}