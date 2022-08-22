using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface Interface1
    {
        void InsertData(string n, string e, string p, int d);
        void UpdateData(int id, string n, string e, string p, int d);
        void DeleteData(int id);
        object DisplayData();
    }
}
