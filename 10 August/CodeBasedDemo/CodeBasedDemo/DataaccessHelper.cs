using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedDemo
{
     class DataaccessHelper
    {
        CodeFirstContext cd = new CodeFirstContext();

        public List<Employee> FetchEmployees()
        {
            return cd.Employees.ToList();
        }
        public List<Department> FetchDepartments()
        {
            return cd.Departments.ToList();
        }

        public int Addemp(Employee e)
        {
            cd.Employees.Add(e);
            cd.SaveChanges();
            return e.Eid;
        }
        public int Adddept(Department e)
        {
            cd.Departments.Add(e);
            cd.SaveChanges();
            return e.Did;
        }


    }
}
