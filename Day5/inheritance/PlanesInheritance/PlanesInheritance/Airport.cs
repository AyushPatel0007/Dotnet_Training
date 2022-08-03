using System;
using System.Collections.Generic;
using System.Text;

namespace PlanesInheritance
{
    class Airport
    {
        public void AcceptPlane(Plane p)
        {
            Console.WriteLine("==================================================");
            p.PalneBelongsTo();
            p.TakeOff();
            p.Fly();
            p.Land();
            Console.WriteLine("==================================================");

        }
    }
}
