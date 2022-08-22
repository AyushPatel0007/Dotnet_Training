using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Demo
{
    public class UnitTestDemo
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a *b;

        }
        public int div(int a, int b)
        {
            return (b==0)?0:a%b;
        }
    }
}
