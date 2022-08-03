using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodOverloading
    {
        int a, b;
        public MethodOverloading(int i,int j)
        {
            a = i;
            b = j;
            
        }
        public void dip()
        {
            Console.WriteLine(a.ToString() + b);
        }
    }
}
