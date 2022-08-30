using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Await_Async
{
   

    public class Program
    {

        public async static void Method()
        {
            Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
            Console.ReadLine();
        }
        public static void LongTask()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Second Thread");
        }
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
    }
}
