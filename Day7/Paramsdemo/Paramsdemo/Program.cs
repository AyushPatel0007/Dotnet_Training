using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramsdemo
{
    class Program
    {
        //public static void paramdemo(params int[] arr)
        public static void paramdemo(params object[] arr)
        { 
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]+(i<arr.Length-1?",":""));
        }
        public static void namesparameterdemo(string s1,string s2,string s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }
        public static void optionalparameter(string s,int a=15,string str = "lucky")
        {
            Console.WriteLine(s);
            Console.WriteLine(str);
            Console.WriteLine(a);

        }
        public static void mulval(dynamic val)
        {
            val *= val; 
            Console.WriteLine(val);
        }
        
        static void Main(string[] args)
        {

            mulval(3);


           // optionalparameter("abc",1);
            //optionalparameter("abc");



           // string n = "hasvd";
            //paramdemo(1, 2, 3, 4, 5, 6);
            //paramdemo(1, 2, 3, 4, 5, 'a',"aysb");
            //namesparameterdemo(s1: "lucky", s2: "singh", s3: "XYZ");
           
        }
    }
}
