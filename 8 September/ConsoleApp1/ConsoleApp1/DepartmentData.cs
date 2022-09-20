using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DepartmentData:IDepartment
    {
        public List<Department> GetData()
        {
            List<Department> dt = new List<Department>()
            {
                new Department(){
                    Id=1,
                    Name="Student"
                },
                new Department()
                {
                    Id=2,
                    Name="Ayush"
                }
            };
            return dt;

            
        }
    }
}
