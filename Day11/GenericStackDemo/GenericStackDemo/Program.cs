using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(6);
            st.Push(5);
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------Peek------------------");
            Console.WriteLine("peek value is "+st.Peek());


            Console.WriteLine("-----------Pop value------------------");
            Console.WriteLine("Value that is pop"+st.Pop());
            Console.WriteLine("Value that is pop" + st.Pop());



            Console.WriteLine("-----------Count------------------");
            Console.WriteLine(st.Count);
            Console.WriteLine("-----------Contains------------------");
            Console.WriteLine(st.Contains(3));
            Console.WriteLine("-----------Copy One stack to another------------------");
            Stack<int> st1 = st;
            foreach(var i in st1)
            {
                Console.WriteLine(i);
            }






        }
    }
}
