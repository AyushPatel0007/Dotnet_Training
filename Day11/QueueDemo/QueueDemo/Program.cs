using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue("ABC");
            qu.Enqueue("BCD");
            qu.Enqueue("CDE");
            qu.Enqueue("DEF");
            qu.Enqueue("EFG");
            Console.WriteLine("-------Before delete--------");
            foreach (var i in qu)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Count value is: " + qu.Count);
            Console.WriteLine("Peek value is: " + qu.Peek());
            Console.WriteLine("ABC value in queue (true/false): "+qu.Contains("ABC"));
            Console.WriteLine("Total queue {0} value", qu.Count);
            Console.WriteLine("Delete element "+qu.Dequeue());
            Console.WriteLine("-------After delete--------");
            foreach (var i in qu)
            {
                Console.WriteLine(i);
            }


        }
    }
}
