using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Plane
    {
        public void PlaneBelogs()
        {
            Console.WriteLine("Belong to Bang");
        }
        internal virtual void Takeoff()
        {
            Console.WriteLine("Plane takeoff");
        }
        public virtual void Land()
        {
            Console.WriteLine("plane wll land");
        }
        public virtual void Fly()
        {
            Console.WriteLine("plane will fly");

        }
    }
}
