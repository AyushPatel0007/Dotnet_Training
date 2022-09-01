using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Demo.Models
{
    public class RechargeModel
    {
        public int Id { get; set; }
        public int Mobile { get; set; }
        public int Recharge { get; set; }

        public static List<RechargeModel> GetAllRecharge()
        {
            List<RechargeModel> rm = new List<RechargeModel>()
            {
                new RechargeModel()
                {
                    Id=1,
                    Mobile=90890,
                    Recharge=90
                },
                new RechargeModel()
                {
                    Id=2,
                    Mobile=9089,
                    Recharge=91
                },
                new RechargeModel()
                {
                    Id=3,
                    Mobile=908,
                    Recharge=92
                }

            };
            return rm;
        }

    }
}