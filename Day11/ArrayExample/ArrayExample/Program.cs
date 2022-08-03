using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("hello");
            arr.Add("hello1");
            arr.Add("hello2");
            arr.Add("hello3");
            arr.Add(12);
            arr[4] = arr[4].ToString();
            foreach(var item in arr)
                Console.WriteLine(item);


        
            Console.WriteLine("Before {0}",arr.Count);


            Console.WriteLine("-------Insert --------------");
            arr.Insert(1, "Inserted1");

            foreach (var item in arr)
                Console.WriteLine(item);
            Console.WriteLine("After {0}", arr.Count);
            Console.WriteLine("-----------Sort----------");

            arr.Sort();
            foreach (var item in arr)
                Console.WriteLine(item);
            Console.WriteLine("----------Reverse-----------");
            arr.Reverse();
            foreach (var item in arr)
                Console.WriteLine(item);

            Console.WriteLine("----------Remove-----------");
            arr.Remove("hello2");
            foreach (var item in arr)
                Console.WriteLine(item);
            Console.WriteLine("----------RemoveAt-----------");
            arr.RemoveAt(0);
            foreach (var item in arr)
                Console.WriteLine(item);

            Console.WriteLine("----------RemoveRange-----------");
            arr.RemoveRange(2,1);
            foreach (var item in arr)
                Console.WriteLine(item);
            //Console.WriteLine("----------ClearAll-----------");
            //arr.Clear();
            //foreach (var item in arr)
            //    Console.WriteLine(item);


            Console.WriteLine("----------Conatins-----------");
             
            Console.WriteLine(arr.Contains("heelo0"));

            Console.WriteLine("----------GetRange----------");

            ArrayList names = new ArrayList(0);
            names = arr.GetRange(0, 3);
            foreach (var item in names)
                Console.WriteLine(item);

        }
    }
}
