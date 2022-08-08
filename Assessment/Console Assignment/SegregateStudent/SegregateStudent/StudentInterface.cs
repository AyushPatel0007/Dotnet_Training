using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregateStudent
{
    
        internal interface Interface1
        {
           bool Add(ref List<Student> st, ref int num);
        }
        internal interface Interface3
        {
            bool disp(ref List<Student> st);
        }
        internal interface Interface2
        {
            bool delete(ref List<Student> st);
        }
        internal interface Interface4
        {
            bool findV(ref List<Student> st);
        }
        internal interface Interface5
        {
            bool updated(ref List<Student> st);
        }


}
