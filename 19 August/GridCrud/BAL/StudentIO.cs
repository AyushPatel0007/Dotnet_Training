using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class StudentIO
    {
        Service s = new Service();
        public object Displaystudent()
        {
            return s.DisplayData();
        }
        public void Deletestudent(int i)
        {
            s.DeleteData(i);
        }
        public void Updatestudent(int id, string n, string e, string p, int d)
        {
            s.UpdateData(id,n,e,p,d);
        }
        public string Insertstudent(string n, string e, string p, int d)
        {
           return s.InsertData(n,e, p, d);
        }
    }
}
