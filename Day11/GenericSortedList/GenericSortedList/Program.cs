using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(11, "China");
            sl.Add(2, "Pak");
            sl.Add(3, "England");
            sl.Add(9, "EDubai");
            sl.Add(4, "India");
            foreach(var i in sl)
            {
                Console.WriteLine(i.Key+" "+i.Value);
            }
            Console.WriteLine("----------Count-------------");
            Console.WriteLine("Count is "+sl.Count);

            Console.WriteLine("----------Contains by key and value-------------");
            Console.WriteLine("Contains key  11 " + sl.ContainsKey(11));
            Console.WriteLine("Contains Value Pak" + sl.ContainsValue("Pak"));
            Console.WriteLine("----------Remove 2 Remove at 2----------");
            sl.Remove(2);
            sl.RemoveAt(2);
            foreach (var i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("---------- TrygetValue-------------");
            sl.TryGetValue(11, out string value);
            Console.WriteLine("Having the value "+value);
            Console.WriteLine("---------- replace-------------");
            sl[11] = "Kolkata";
            Console.WriteLine("After replaced ");
            foreach (var i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }


        }
    }
}
