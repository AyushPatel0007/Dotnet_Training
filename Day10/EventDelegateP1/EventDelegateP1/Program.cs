using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateP1
{
    public delegate void Access();

    class Program
    {
        public void message()
        {
            Console.WriteLine("Access Function by delegates");
        }
        public void message1()
        {
            Console.WriteLine("Access Function by delegates1");
        }
        public void message2()
        {
            Console.WriteLine("Access Function by delegates2");
        }


        public static int add(int a,int b)
        {
            return a * b;
        }
        public static bool pred(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //anonymous
        public delegate string Greeting(string s);

        //end
        static void Main(string[] args)
        {

            Func<int, int, int> f = new Func<int, int, int>(add);
            Console.WriteLine(f(2, 5));
            Predicate<int> pp = new Predicate<int>(pred);
            Console.WriteLine(pp(8));






            //anonymous
            Greeting obj = delegate (string name)
              {
                  return "Hello employees " + name;
              };         
            Console.WriteLine(obj.Invoke("Happy day"));
            //end





            //multiDelegates
            Program p = new Program();
            Access a = new Access(p.message);
            a += p.message1;
            a.Invoke();
            //end 
             

        }
    }
}
