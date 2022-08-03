using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate string FirstDelegate(int x);
    class Program
    {
        string name="Abk";

        static string StaticMethod(int i)
        {
            return string.Format("{0}", i);
        }
        string InstanceMethod(int i)
        {
            return string.Format("{0} {1}", i,name);
        }
        static void Main(string[] args)
        {
            FirstDelegate f1 = new FirstDelegate(Program.StaticMethod);
            Program instance = new Program();
            instance.name = "Lucky";
            FirstDelegate f2 = new FirstDelegate(instance.InstanceMethod);
            Console.WriteLine(f1(10));
            Console.WriteLine(f2(5));

        }
    }
}
