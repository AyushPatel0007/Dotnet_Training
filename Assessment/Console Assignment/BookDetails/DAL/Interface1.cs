using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface Interface1
    {
        string InsertData(int id, string name, string author, string publisher, int price);
        object DisplayData();
        string UpdateData(int id, string name, string author, string publisher, int price);
        string DeleteData(int id);

    }
}
