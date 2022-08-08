 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregateStudent
{
    class Program
    {
        static int num = 0;

        static List<Student> st = new List<Student>();
        static void Main(string[] args)
        {
            bool f = true;
            StudentMethods stu = new StudentMethods();
            while (f)
            {
                Console.Write("1 to Add\n2 to Display \n3 To Delete \n4 To Find \n5 To Update \nOther to exit \nEnter choice ");
                int n = int.Parse(Console.ReadLine());
               
                switch (n)
                {
                    case 1: f = stu.Add(ref st,ref num); break;
                    case 2: f = stu.disp(ref st); break;
                    case 3: f = stu.delete(ref st); break;
                    case 4: f = stu.findV(ref st); break;
                    case 5: f = stu.updated(ref st); break;
                    default: f = false; Console.WriteLine("Thanks for visit"); break;
                }


            }

        }

    }
}
