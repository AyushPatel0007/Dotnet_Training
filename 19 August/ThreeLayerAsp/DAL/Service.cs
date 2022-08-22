using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Service
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");

        public bool Add(string n, string e, string p, int i)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("InsertStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", n));
            cmd.Parameters.Add(new SqlParameter("@email", e));
            cmd.Parameters.Add(new SqlParameter("@password", p));
            cmd.Parameters.Add(new SqlParameter("@did", i));
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            
            
            return true;

        }
        public bool UpdatebyId(int id,string n, string e, string p, int i)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Updatebyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Parameters.Add(new SqlParameter("@name", n));
            cmd.Parameters.Add(new SqlParameter("@email", e));
            cmd.Parameters.Add(new SqlParameter("@password", p));
            cmd.Parameters.Add(new SqlParameter("@did", i));

            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }
        public bool Deleteid(int i)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from students where Sid='" + i + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }
        public SqlDataReader Findid(int i)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where Sid='" + i + "'", con);
            SqlDataReader r = cmd.ExecuteReader();
            return r;
            con.Close();


        }

        public DataTable Display( )
        {
             con.Open();
            SqlCommand cmd = new SqlCommand("SelectStudent", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }

    }
}
