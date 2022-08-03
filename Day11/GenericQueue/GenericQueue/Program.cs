using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> st = new Queue<int>();
            st.Enqueue(1);
            st.Enqueue(2);
            st.Enqueue(3);
            st.Enqueue(4);
            st.Enqueue(6);
            st.Enqueue(5);
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------Peek------------------");
            Console.WriteLine("peek value is " + st.Peek());


            Console.WriteLine("-----------Pop value------------------");
            Console.WriteLine("Value that is pop" + st.Dequeue());
            Console.WriteLine("Value that is pop" + st.Dequeue());



            Console.WriteLine("-----------Count------------------");
            Console.WriteLine(st.Count);
            Console.WriteLine("-----------Contains------------------");
            Console.WriteLine(st.Contains(3));
            Console.WriteLine("-----------Copy One stack to another------------------");
            Queue<int> st1 = st;
            foreach (var i in st1)
            {
                Console.WriteLine(i);
            }


        }
    }
}
