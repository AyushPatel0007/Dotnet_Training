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
            List<StudentVar> st = new List<StudentVar>();

            StudentMethods stu =new StudentMethods();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1:Insert\n2:Display\n3:Delete\n4:Update\n5:Count\nOther:Exit");
                Console.Write("Enter choice: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                switch (n) {
                    case 1:

                         Console.WriteLine("Enter the Name");
                        string nn = Console.ReadLine();
                        Console.WriteLine("Enter the Marks");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Address");
                        string a = Console.ReadLine();
                        st.Add(new StudentVar(0, nn, m, a));
                        flag =stu.Insert(st);
                             break;
                    case 2:
                        List<StudentVar> st2 = new List<StudentVar>();

                        st2 = stu.Display();
                        for(int i = 0; i < stu.Count();i++)
                        {
                            Console.WriteLine(st2[i].id+" " + st2[i].Name+" " + st2[i].Marks+" " + st2[i].Address);
                        }
                        Console.WriteLine("-----------------------------------------");

                        break;
                    case 3:
                        Console.Write("Enter id: ");
                        int mm = int.Parse(Console.ReadLine());
                        flag = stu.Delete(mm);
                        break;
                    case 4:
                        List<StudentVar> stk = new List<StudentVar>();
                        Console.Write("Enter id: ");
                        int u = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Name: ");
                        string nan = Console.ReadLine();
                        Console.Write("Enter the Marks: ");
                        int mar = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Address: ");
                        string aa = Console.ReadLine();
                        stk.Add(new StudentVar(u, nan, mar, aa));
                        flag = stu.Update(stk);
                        break;
                    case 5:
                        int k = stu.Count();
                        Console.WriteLine("Number of Row :{0}", k);
                        Console.WriteLine("-----------------------------------------");
                        break;

                     default:flag = false; break;
                        
                
                }


            }
        }
    }
}
