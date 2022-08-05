using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal interface StudentInterface
    {
        bool Insert(List<StudentVar> st);
        bool Delete(int n);
        int Count();
        bool Update(List<StudentVar> st);

        List<StudentVar> Display();
    }
}
