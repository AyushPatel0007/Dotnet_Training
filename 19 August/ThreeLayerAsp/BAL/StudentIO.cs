using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    
    public class StudentIO
    {
        Service s = new Service();
        DALayer d=new DALayer();
        public bool AddStu(string n,string e,string p,int i)
        {
            if(d.InsertData(n, e, p, i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public object DisplayStudent()
        {
            return d.selectData();
        }
        public bool Deletebyid(int i)
        {
            if (d.DeleteData(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public SqlDataReader Findbyid(int i)
        {
            return s.Findid(i);
        }
        public bool UpdateStudent(int id,string n, string e, string p, int i)
        {
            if (d.UpdateData(id,n,e,p,i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
