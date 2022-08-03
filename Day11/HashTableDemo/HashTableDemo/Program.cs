using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("ms", "UsA");
            hash.Add("sony", "calfornia");
            hash.Add("mercedes", "germany");
            hash.Add(1, "Europe");
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine("----------Count--------------");
            Console.WriteLine(hash.Count);

            Console.WriteLine("----------Remove--------------");

            hash.Remove("sony");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("----------Contains/ContainsValue--------------");

            Console.WriteLine(hash.Contains(1));
            Console.WriteLine(hash.ContainsValue("Europe"));


        }
    }
}
