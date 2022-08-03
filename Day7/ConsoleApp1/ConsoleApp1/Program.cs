using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class operatordemo
    {
        int sum, result;
        public operatordemo(int s, int r)
        {
            sum = s;
            result = r;
        }
       public void disp()
        {
            Console.WriteLine(sum.ToString() + result);

        }
        public static operatordemo operator-(operatordemo op){
            op.sum = +op.sum;
            op.result = +op.result;
            return op;           

        }
        public virtual void status()
        {
            Console.WriteLine("Hello");
        }
}

    class Program 
    {
        static void Main(string[] args)
        {
            double r, l, b;


            operatordemo op = new operatordemo(1,3);
            op.disp();
            op = -op;
            op.disp();

            MethodOverloading mo = new MethodOverloading(10, 20);
            mo.dip();
            MethodOverloading m1 = new MethodOverloading(10, 20);
            m1.dip();
            MethodOverloading m2 = m1;
            m2.dip();
            if (mo.Equals(m1))
            {
                Console.WriteLine("Equal");

            }
            else
            {
                Console.WriteLine("Nnot equal");
            }
            if (m1.Equals(m2))
            {
                Console.WriteLine("Equal");

            }



















            //Console.WriteLine("Rectangle Area");
            //Console.WriteLine("Enter the Length");
            //l = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Width");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Rectangle Area is "+Area(l,b).ToString());


            //Console.WriteLine("Circle Area");
            //Console.WriteLine("Enter the size of Radius");
            //r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Circle Area is " + Area(r).ToString());


        }

        static double Area(double l, double b)
        {
            return l * b;
        }
        static double Area(double r)
        {
            return r * r * r;
        }
    }
}
