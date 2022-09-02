using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Demo.Models;

namespace WebApi_Demo.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("GetAllRecharge")]
        public List<RechargeModel> Get()
        {
            return RechargeModel.GetAllRecharge();
        }
        [Route("GetDetails/{id}")]
        [HttpGet]
        public RechargeModel Get(int id)
        {
            return RechargeModel.GetAllRecharge().FirstOrDefault(x => x.Id == id);
        }

        
        public string Post(RechargeModel r)
        {
            if (r != null)
            {
                return "successsful";
            }
            else
            {
                return "successsful not sucees";
            }

        }
        [HttpGet]
        [Route("DeleteRecharge/{id}")]
        public string Post(int id)
        {

            
                return "successsful deleted";
           
        }

    }
}
