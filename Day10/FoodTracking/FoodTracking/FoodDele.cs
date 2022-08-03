using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracking
{
    class FoodDele
    {
        public delegate void Status(int i);
        public void Foodprepare(Status obj)
        {
            for(int i = 1; i < 5; i++)
            {
                obj(i);
            }
        }
    }
}
