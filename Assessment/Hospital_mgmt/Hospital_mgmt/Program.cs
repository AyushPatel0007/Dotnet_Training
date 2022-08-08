using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hospital_mgmt
{
    class Program
    {
        static List<Patient> p = new List<Patient>();

        static void Main(string[] args)
        {
        Patientservice pt = new Patientservice();
            bool f = true;
            while (f)
            {
                Console.Write("1 to Add\n2 to Display \n3 To Delete \n4 To Update \nOther to exit \nEnter choice ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------");

                switch (n)
                {
                    case 1: f = pt.Add(ref p); break;
                    case 2: f = pt.Display(ref p); break;
                    case 3: f = pt.Delete(ref p); break;
                    case 4: f = pt.Updated(ref p); break;
                    default: f = false; Console.WriteLine("Thanks for visit"); break;
                }
            }
         }
        


       
    }
}
