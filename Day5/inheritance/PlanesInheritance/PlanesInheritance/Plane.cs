using System;
using System.Collections.Generic;
using System.Text;

namespace PlanesInheritance
{
    class Plane
    {
        public  void PalneBelongsTo()
        {
            Console.WriteLine("plane belongs to banglore airport");
        }
        internal virtual void TakeOff()
        {
            Console.WriteLine("plane take off");
        }
        public virtual void Fly()
        {
            Console.WriteLine("plane will fly");
        }
        public virtual void Land()
        {
            Console.WriteLine("plane will land");
        }
    }
}
