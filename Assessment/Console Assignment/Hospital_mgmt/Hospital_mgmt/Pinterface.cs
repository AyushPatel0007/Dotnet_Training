using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_mgmt
{
    interface Pinterface
    {
        bool Add(List<Patient> pt);
        bool Display(List<Patient> pt);
        bool Delete(List<Patient> pt);
        bool Updated(List<Patient> pt);
    }
}
