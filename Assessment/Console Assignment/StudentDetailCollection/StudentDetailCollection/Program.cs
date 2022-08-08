using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailCollection
{
    class Program
    {


        static int num = 0;

        static List<Student> st = new List<Student>();
        static void Main(string[] args)
        {
            bool f = true;
            
            while (f)
            {
                Console.Write("1 to Add\n2 to Display \n3 To Delete \n4 To Find \nOther to exit \nEnter choice ");
                int n = int.Parse(Console.ReadLine());
                switch (n) {
                    case 1:f=Add();break;
                    case 2:f=disp();break;
                    case 3: f = delete(); break;
                    case 4: f = findV(); break;
                    default:f = false; Console.WriteLine("Thanks for visit");break;
                }


            }

        }


        public static bool Add()
        {
             
                Console.Write("Enter id: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter name : ");
                string s = Console.ReadLine();
                Console.WriteLine("----------------------");
                st.Add(new Student());
                st[num]._id=n;
                st[num++]._name=s;
                return true;
          

        }
        public static bool disp()
        {
            Console.WriteLine("---------Result-------------");

            foreach (Student ob in st)
            {
                Console.WriteLine("Id : "+ob.Gid()+" Name : "+ob.Gname());
            }
            Console.WriteLine("----------------------");

            return true;
        }
        public static bool delete()
        {
            Console.Write("1 to Id\n2 to Name\nEnter Choice : ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            switch (n)
            {
                case 1:
                    Console.Write("Enter Id  to Delete : ");
                    int res = int.Parse(Console.ReadLine());
                    foreach (Student obj in st)
                    {
                        if (obj.Gid() == res)
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                    {
                        st.RemoveAt(k);
                        Console.WriteLine("Deleted Succcessfull");
                    }
                    else
                        Console.WriteLine("Id not found");
                    Console.WriteLine("-------------------------");
                    break;
                case 2:
                    Console.Write("Enter Name to find: ");
                    string ress = Console.ReadLine();
                    foreach (Student obj in st)
                    {
                        if (obj.Gname() == ress)
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                    {
                        st.RemoveAt(k);
                        Console.WriteLine("Deleted Succcessfull");
                    }
                    Console.WriteLine("Name not found");
                    Console.WriteLine("------------------------");
                    break;
                case 3:return true;break;

            }
                    return true;
            }


        public static bool findV()
        {
            Console.Write("1 to Id\n2 to Name\nEnter Choice : ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            switch (n) {
                case 1:
                    Console.WriteLine("Enter Id  to find : ");
                    int res = int.Parse(Console.ReadLine());
                     foreach (Student obj in st)
                    {
                        if (obj.Gid() ==res)
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                        Console.WriteLine("Id Available at {0} index", k);
                    else
                        Console.WriteLine("Id not found");
                    Console.WriteLine("-------------------------");
                    break;
                case 2:
                    Console.Write("Enter Name to find: ");
                    string ress = Console.ReadLine();
                    foreach (Student obj in st)
                    {
                        if (obj.Gname() == ress)
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                        Console.WriteLine("Name Available at {0} index", k);
                    else
                        Console.WriteLine("Name not found");
                    Console.WriteLine("------------------------"); 
                    break;
                case 3: return true; break;



            }

            return true;
        }
    }
}
