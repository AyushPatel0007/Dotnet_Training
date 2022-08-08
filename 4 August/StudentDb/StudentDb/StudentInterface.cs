using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal interface StudentInterface
    {
        bool Insert();
        bool Delete(int n);
        bool Count();
        bool Update(int n);
        bool Display();
    }
}
