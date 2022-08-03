using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventpractise
{

    class student{
        public int i, j;
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, student> st = new SortedList<int, student>();
            st.Add(1, new student());
            st[1].i = 1;
            st[1].j = 1;
        
            {
                Console.WriteLine(st[1].Keys);
            }

        }
    }
}
