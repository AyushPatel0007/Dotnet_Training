using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The name of the book is"; 
            string k = "The Secret";
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.EndsWith("is"));
            //Console.WriteLine(s.LastIndexOf("o"));
            //Console.WriteLine(s.Equals(k));
            // Console.WriteLine(s.Replace("the","This"));
            //Console.WriteLine(s.Remove(0,3));
            //Console.WriteLine(string.Compare(s,k));  
            //Console.WriteLine(string.Concat(s," ","add ",k)); 
            StringBuilder s1 = new StringBuilder();
            
            Console.WriteLine(s1.Append("word"));



        }
    }
}
