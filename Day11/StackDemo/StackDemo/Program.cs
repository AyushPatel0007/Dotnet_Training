using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("Push1");
            st.Push("Push2");
            st.Push("Push3");
            st.Push("Push4");
            st.Push("Push5");
            st.Push("Push6");
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(st.Contains("Push1")); 

            Console.WriteLine(st.Peek()) ; 
            Console.WriteLine("Sequening of remove");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
    }
}
