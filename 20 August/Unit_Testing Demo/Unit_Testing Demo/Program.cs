using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Demo
{
    public class Program
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public bool Div(int a, int b)
        {
            if (a % b == 0 && b != 0) return true;
            else return false;
        }
        public int Mul(int a, int b)
        {
            if ( b != 0||a!=0) return a*b;
            else return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 7)) ;
         }
    }
}
