using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodDele fd = new FoodDele();
            fd.Foodprepare(Foodst);
            Console.ReadLine();

        }

        public static void Foodst(int i)
        {
            switch (i)
            {
                case 1: Console.WriteLine("Starting"); break;
                case 2: Console.WriteLine("Cutting"); break;
                case 3: Console.WriteLine("Coooking"); break;

                case 4: Console.WriteLine("Delivered"); break;

                default: Console.WriteLine("out of delivery"); break;

            }
        }


    }
}
