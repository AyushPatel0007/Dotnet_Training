using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_mgmt
{
    interface Pinterface
    {
        bool Add(ref List<Patient> pt);
        bool Display(ref List<Patient> pt);
        bool Delete(ref List<Patient> pt);
        bool Updated(ref List<Patient> pt);
    }
}
