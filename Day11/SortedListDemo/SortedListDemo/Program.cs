using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sorted = new SortedList();
            sorted.Add(6, "Abc");
            sorted.Add(2, "BCD");
            sorted.Add(3, "Cde");
            sorted.Add(4, "EFG"); ;
            sorted.Add(5, "BFE");
            foreach(DictionaryEntry item in sorted)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("----------Getkey-------------------");
            for(int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted.GetKey(i)+" "+sorted.GetByIndex(i));
            }
            Console.WriteLine("----------Remove-------------------");
            sorted.Remove(2);
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted.GetKey(i) + " " + sorted.GetByIndex(i));
            }
            Console.WriteLine("----------Array-------------------");
            ArrayList arr = new ArrayList(sorted.Values);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("----------Count--{0}-----------------",sorted.Count);
            Console.WriteLine(sorted[6].ToString());

        }
    }
}
