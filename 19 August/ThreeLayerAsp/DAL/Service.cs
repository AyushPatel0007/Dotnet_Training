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
            SqlCommand cmd = new SqlCommand("InsertStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", n));
            cmd.Parameters.Add(new SqlParameter("@email", e));
            cmd.Parameters.Add(new SqlParameter("@password", p));
            cmd.Parameters.Add(new SqlParameter("@did", i));

            cmd.ExecuteNonQuery();
            con.Close();
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

        public SqlDataReader Display( )
        {
             con.Open();
            SqlCommand cmd = new SqlCommand("select * from students", con);
            var r=cmd.ExecuteReader();
            //while(r.Read())
            //{
            //    st.Add(new Student());
            //    st[st.Count].id = int.Parse(r[0].ToString());
            //    st[st.Count].name = r[1].ToString();
            //    st[st.Count].email = r[2].ToString();
            //    st[st.Count].password = r[3].ToString();
            //    st[st.Count].did = int.Parse(r[4].ToString());

            //}
            return r;
            con.Close();

        }

    }
}
