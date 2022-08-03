using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contactinfo ci = new Contactinfo("ABC","UP","LKO",95);                  
            Contactinfomanager cim = new Contactinfomanager();
            cim.displayContactDetail(ci);


        }
    }
}
