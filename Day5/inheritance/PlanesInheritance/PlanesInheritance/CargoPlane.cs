using System;
using System.Collections.Generic;
using System.Text;

namespace PlanesInheritance
{
    class CargoPlane:Plane
    {
        internal override void TakeOff()
        {
            Console.WriteLine("Cargoplane wants long run way to take off");
            
        }
        public override void Fly()
        {
            Console.WriteLine(" Cargoplane fly with low speed");
            
        }
        public override void Land()
        {
            Console.WriteLine("Cargoplane to land wants long run way");
            
        }
    }
}
