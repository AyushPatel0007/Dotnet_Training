using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleoops
{
    abstract class employee
    {
        public void Status()
        {
            Console.WriteLine("Abstact class public function");
        }
        public abstract void mul();
         
    }
     

    class customer : employee 
    {
        
        public override void mul()
        {
            base.Status();
            Console.WriteLine("Override customer");
        }

    }
    class customer1 : employee
    {

        public override void mul()
        {
            base.Status();
            Console.WriteLine("Override customer1");
        }

    }
 
    public static class clst
    {
        public static void Numk()
        {

            Console.WriteLine("Static Class");
        }

    }
    class clspublic
    {
        public void Numk1()
        {
            Console.WriteLine("Public class");
        }
        public int Numk11(int n)
        {
            return n;
        }
    }

    interface IA
    {
        void Display();
    }
    
    class Program
    {
        static void Main(string[] args)
        {


            ///static
            customer cu = new customer();
            customer1 cu1 = new customer1();
            cu.mul();
            cu1.mul();


            //public
            //clspublic cp = new clspublic();
            //cp.Numk1();
            //Console.WriteLine(cp.Numk11(9));



        }

    }
}
