using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CargoPlane:Plane
    {
        internal override void Takeoff()
        {
            Console.WriteLine("Wants long run to take offf");
        }
        public override void Land()
        {
            Console.WriteLine("to land wants long run");
        }
        public override void Fly()
        {
            Console.WriteLine("Wants long run to fly offf");

        }
    }
}
