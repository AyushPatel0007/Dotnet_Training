using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Demo.Models
{
    public class EmployeeBusinessLayer
    {
        public Employees GetAllDetails()
        {
            Employees em = new Employees() { 
            Empid=1,Name="ritik",City="Noida",Gender="Male",Price=145
            };
            return em;
        }


        public List<Employees> GetAllDetail()
        {
            List<Employees> em = new List<Employees>()
            {
                new Employees()  { Empid = 1,
                Name = "ritik",
                City = "Noida",
                Gender = "Male",
                Price = 145
                },

                 new Employees()  { Empid = 2,
                Name = "ritik2",
                City = "Noida",
                Gender = "Male",
                Price = 145
                }
            };
        

            return em;
        }


    }
}