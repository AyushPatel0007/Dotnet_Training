using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataaccessHelper dt = new DataaccessHelper();

            Department dp = new Department() {

                    Dname = "IT",
                Employees=new List<Employee>
                    {
                                new Employee(){Ename="Lucky"},
                                new Employee(){Ename="Sandy"},
                                new Employee(){Ename="Elvish"}
                     }
            
            
            };
             dt.Adddept(dp); 
            var Added = dt.FetchDepartments().FirstOrDefault();
             if (Added != null)
            {
                Console.WriteLine(Added.Dname);
                foreach(var AddedEmployes in Added.Employees)
                {
                    Console.WriteLine(AddedEmployes.Ename);
                }

            }
        }
    }
}
