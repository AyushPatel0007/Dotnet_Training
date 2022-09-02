using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace WebApi
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //using (WebClient webclient = new WebClient())
            //{
            //    webclient.Headers.Add("Content-type:application/json");
            //    webclient.Headers.Add("Accept:application/json");
            //    var response = webclient.DownloadString("https://localhost:44333/GetAllRecharge");
            //    Console.WriteLine(response);

            //}


            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44349/GetAllStudent");
                Console.WriteLine(response);
            }

        }
    }
}
