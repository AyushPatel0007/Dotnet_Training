using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("india", "delhi");
            dict.Add("russia","moscow");
            dict.Add("italy","rome");
            dict.Add("england", "london");
            dict.Add("germany", "berlin");

            foreach(var i in dict)
            {
                Console.WriteLine(i.Key+" "+i.Value);
            }

            Console.WriteLine("------------Second dict-----------------");
            Dictionary<int, string> dict1 = new Dictionary<int, string>()
            {
                {6,"USa" },{8,"Egypt"}
            };
            dict1.Add(1, "delhi");
            dict1.Add(2, "moscow");
            dict1.Add(3, "rome");
            dict1.Add(4, "london");
            dict1.Add(5, "berlin");

            foreach (var i in dict1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("------------Change value 2index-----------------");
            dict1[2] = "Dubai";
            foreach (var i in dict1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            Console.WriteLine("------------TrygetValue-----------------");
             
            dict.TryGetValue("russia", out string result);
            Console.WriteLine(result);


            Console.WriteLine("------------Remove dubai second dict1-----------------");
            dict1.Remove(2);
            foreach (var i in dict1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
             
            Console.WriteLine("------------Count-----------------");
            Console.WriteLine(dict.Count);

            Console.WriteLine("------------ContainsValue london----------------"); 
            Console.WriteLine(dict1.ContainsValue("london"));
        }
    }
}
