using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTableAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService s = new StudentService();
            bool f = true,l=true;
            while (l)
            {
                Console.Write("1:Student 2:Department 3:Select data from both\nEnter Choice: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.Write("1:Insert 2:Update 3:delete 4:select\nEnter Choice: ");
                    int k = int.Parse(Console.ReadLine());
                    switch (k) {
                        case 1:f=s.InsertStudent();break;
                        case 2:f = s.UpdateStudent();break;
                        case 3:f = s.DeleteStudent();break;
                        case 4: f = s.SelectStudent(); break;

                        default: f=false;break;
                    
                    
                    }


                }
                else if(n==2)
                {

                    Console.Write("1:Insert 2:Update 3:delete 4:Select\nEnter Choice: ");
                    int k = int.Parse(Console.ReadLine());
                    switch (k)
                    {
                        case 1: f = s.Insertdepartment(); break;
                        case 2: f = s.UpdateDepartment(); break;
                        case 3: f = s.DeleteDepartment(); break;
                        case 4: f = s.SelectDepartment();break;
                        default: f = false; break;


                    }
                }
                else if(n==3)
                {
                    s.SelectUser();


                }
                else
                {
                    l = false;
                }

            }
             
            
        }
    }
}
