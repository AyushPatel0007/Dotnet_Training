using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Contactinfo
    {
        string _address, _city, _state, _emailid;
        int _phoneno, _mobileno;
        public Contactinfo(string address,string city,string state,int mobileno)
        {
            _address = address;
             _city = city;
             _state = state;
             _mobileno = mobileno;

        }
        public Contactinfo()
        {
            
        }



    }
   
}
