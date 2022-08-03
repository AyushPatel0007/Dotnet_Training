using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregateStudent
{
    class Student
    {
        public string _name;
        public int _id;

        public Student()
        {
        }
        public int Gid()
        {
            return this._id;
        }
        public string Gname()
        {
            return this._name;
        }
    }
}
