using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StudentMethods stu=new StudentMethods();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1:Insert\n2:Display\n3:Delete\n4:Update\n5:Count\nOther:Exit");
                Console.Write("Enter choice: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                switch (n) {
                    case 1:              
                        flag =stu.Insert();
                             break;
                    case 2:flag = stu.Display();
                             break;
                    case 3:
                        Console.Write("Enter id: ");
                        int mm = int.Parse(Console.ReadLine());
                        flag = stu.Delete(mm);
                        break;
                    case 4:
                        Console.Write("Enter id: ");
                        int u = int.Parse(Console.ReadLine());
                        flag = stu.Update(u);
                        break;
                    case 5:
                        flag = stu.Count();
                        break;

                     default:flag = false; break;
                        
                
                }


            }
        }
    }
}
