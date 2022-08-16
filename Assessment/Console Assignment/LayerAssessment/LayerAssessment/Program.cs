using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Present;

namespace LayerAssessment
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Presents p = new Presents();
            bool f = true;
            while (f)
            {
                Console.Write("Enter 1:Category Menu()\nEnter 2:Product Menu()\nExit\nEnter Choice: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: f = p.CMenu(); break;
                    case 2:f = p.PMenu();break;
                    default: f = false; break;
                }

            }
        }
    }
}
