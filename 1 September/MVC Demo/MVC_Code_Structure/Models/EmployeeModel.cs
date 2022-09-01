using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Code_Structure.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }

        public static List<EmployeeModel> Empdata()
        {
            List<EmployeeModel> lst = new List<EmployeeModel>() { new EmployeeModel() {
                Name="Amam",City="kjb",Mobile="875"
            },
            new EmployeeModel() {
                Name="Amkiy",City="87",Mobile="43546"
            },
            new EmployeeModel() {
                Name="Amo",City="kjb",Mobile="878576"
            }};


            return lst;
        }

    }
}