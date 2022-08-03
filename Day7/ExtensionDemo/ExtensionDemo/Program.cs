using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    static class demo
    {
        public static int Getword(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string[] ar = s.Split(' ');
                return ar.Count();
            }
            else
            {
                return 0;
            }
        }
        public static int kcount(this string s)
        {
            return s.Count();
        }
    }


    class reftype
    {
        public void mul(ref int i,ref int j)
        {
            j = j * i;
            Console.WriteLine(j);
        }
        public void add( int i,  int j)
        {
            
            Console.WriteLine(i+j);
        }
        
    }
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            //reftype rf = new reftype();
            //int i = 5, j = 10;

            //rf.mul(ref i, ref j);
            //rf.add(i, j);
            ////string str = "fd hgdfasj fghssa";
            ////Console.WriteLine(str.Getword());
            //int n=6,m=2,q=0;
            //string a;
            ////Console.WriteLine(n);
            //outdemo( n, m,out q);
            //Console.WriteLine(q);
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);

        }
        
        public static void outdemo( int n, int m,out int q)
        {
            q=n%m;          
            
        }
    }
}
