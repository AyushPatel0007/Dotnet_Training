using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Contactinfomanager
    {
        
        
        public void displayContactDetail(Contactinfo ci)        {
            Console.WriteLine(ci.address);
            Console.WriteLine(ci.city);            
            Console.WriteLine(ci.state);
            Console.WriteLine(ci.mobileno);
        }

    }
}
