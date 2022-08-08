using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregateStudent
{
    class StudentMethods :  Interface1 
    {

        public StudentMethods()
        {

        }
        public bool Add(ref List<Student> st,ref int num)
        {
            
            Console.Write("Enter id: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter name : ");
            string s = Console.ReadLine();
            Console.WriteLine("----------------------");
            st.Add(new Student());
            st[num]._id = n;
            st[num++]._name = s;
            return true;


        }
        public bool disp(ref List<Student> st)
        {
            Console.WriteLine("---------Result-------------");

            foreach (Student ob in st)
            {
                Console.WriteLine("Id : " + ob.Gid() + " Name : " + ob.Gname());
            }
            Console.WriteLine("----------------------");

            return true;
        }
        public bool delete(ref List<Student> st)
        {
            case1:
            Console.Write("1 to Id\n2 to Name\nEnter Choice : ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            try
            {
                if (n != 1 && n != 2)
                    throw new MyException();
            }
            catch (MyException e) {
                e.Invalidno();
                goto case1;
            }
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

            }
            return true;
        }
        public   bool findV(ref List<Student> st)
        {
            Console.Write("1 to Id\n2 to Name\nEnter Choice : ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter Id  to find : ");
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

        public bool updated(ref List<Student> st)
        {
            Console.Write("1 to Id\n2 to Name\nEnter Choice : ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter Id : ");
                    int res = int.Parse(Console.ReadLine());
                    foreach (Student obj in st)
                    {
                        if (obj.Gid() == res)
                        {
                            k = i;
                        }
                        i++;
                    }
                    
                    if (k != -1)
                    {
                        Console.Write("Enter id to Updated: ");
                        int nn = int.Parse(Console.ReadLine());
                       
                        st[k]._id = nn;
                        Console.WriteLine("---------Updated-------------");
                    }
                    else
                        Console.WriteLine("Id not found");
                    Console.WriteLine("-------------------------");
                    break;
                case 2:
                    Console.Write("Enter Name  : ");
                    string ress = Console.ReadLine();
                    foreach (Student obj in st)
                    {
                        if (obj.Gname() == ress)
                        {
                            k = i;
                        }
                        i++;
                    } 
                     
                        if (k != -1)
                        {
                            Console.Write("Enter name to updated: ");
                            string nn =  Console.ReadLine();
                           
                            st[k]._name = nn;
                            Console.WriteLine("---------Updated-------------");
                        }
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
