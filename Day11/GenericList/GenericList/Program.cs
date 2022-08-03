using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string> { "america", "southkorea", "asia" };
            li.Add("India");
            li.Add("cin");
            li.Add("pak");
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------assign 3 dubai-----------");
            li[3] = "Dubia";
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------Count-----------");
            Console.WriteLine(li.Count);

            Console.WriteLine("------------Remove cin-----------");
             li.Remove("cin");
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------Reversing-----------");
            li.Reverse();
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------Clearing-----------");
           // li.Clear();
            //foreach (var i in li)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("------------Copying first to second-----------");
            List<string> second = li;
            foreach (var i in second)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------Contain pak (True/false)-----------");
            Console.WriteLine(second.Contains("pak"));

            Console.WriteLine("------------Copying first to second by Range-----------");
            List<string> second1 = li.GetRange(0,3);
            foreach (var i in second1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
