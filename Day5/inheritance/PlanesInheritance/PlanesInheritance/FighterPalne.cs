using System;
using System.Collections.Generic;
using System.Text;

namespace PlanesInheritance
{
    class FighterPalne:Plane
    {
        internal override void TakeOff()
        {
            Console.WriteLine("Fighter palne take off in small runway");
        }
        public override void Fly()
        {
            Console.WriteLine("Fighter palne fly with high speed");
        }
        public override void Land()
        {
            Console.WriteLine("Fighter plane land in small runway");
        }
    }
}
