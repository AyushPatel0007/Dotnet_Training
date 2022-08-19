using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class Service
    {
        SqlConnection con;
        public void connect()
        {
            con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");
        }


        public object DisplayData()
        {
            connect();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from students", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;
        }



        public void DeleteData(int id)
        {
            connect();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("delete from students where Sid='" + 2 + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
           

        }
        public void UpdateData(int id,string n,string e,string p,int d)
        {
            connect();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("update students set Sname='" + n + "',Semail='" + e + "',Spassword='" + p+ "',Departments_Did='" + d + "' where Sid='"+id+"'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
        }
        public void InsertData(string n, string e, string p, int d)
        {
            connect();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("insert into students values('"+n+"','"+e+"','"+p+"','"+d+"')", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
        }

    }
}
