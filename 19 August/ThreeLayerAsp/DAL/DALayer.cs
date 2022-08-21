using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALayer
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");

        DataSet1.SelectStudentDataTable stuDT = new DataSet1.SelectStudentDataTable();
        DataSet1TableAdapters.SelectStudentTableAdapter stuDA = new DataSet1TableAdapters.SelectStudentTableAdapter();

        public bool InsertData(string n, string e, string p, int i)
        {
            int res = stuDA.Insert(n, e, p, i);
            return true;
        }
        public bool DeleteData(int i)
        {
            int res = stuDA.Delete(i); 
            return true;

        }
        public bool UpdateData(int id,string n, string e, string p, int i)
        {
            int res = stuDA.Update(id,n, e, p, i);
            return true;
        }
        public object selectData()
        {
            return stuDT = stuDA.GetData();

        }
        public object SelectbyId(int id)
        {
            return stuDT = stuDA.GetDataBy(id);
        }

        //public bool InsertData(string n, string e, string p, int i)
        //{
        //    con.Open();
        //    SqlDataAdapter sq = new SqlDataAdapter("", con);
        //    DataTable dt = new DataTable();
        //    sq.Fill(dt);
        //    dt.AcceptChanges();
        //    return true;
        //}
    }
}
