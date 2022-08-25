using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Twotable_cba.Models
{
    public class CompContext:DbContext
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo10;Integrated Security=True");
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public void InsertDepart(Department dt)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Departments values('" + dt.Dname + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return;

        }
        public void StudentUpdate(Student st)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update students set Sname='"+st.Sname+"',Semail='"+st.Semail+ "',Spassword='"+st.Spassword+ "',Departments_Did='"+st.Departments_Did+"' where Sid='"+st.Sid+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return;

        }
        public void StudentAdd(Student dt)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Students values('" + dt.Sname + "','"+dt.Semail+ "','"+dt.Spassword+ "','"+dt.Departments_Did+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return;

        }
        public List<Student> Select()
        {
            con.Open();
//SqlCommand cmd = new SqlCommand("select S.Sid,S.Sname,S.Semail,S.Spassword,S.Departments_Did,D.Did,D.Dname from students as S inner join departments as D on S.Departments_Did==D.Did", con);

            SqlCommand cmd = new SqlCommand("select * from students", con);
            SqlDataReader res=cmd.ExecuteReader();
            List<Student> lst = new List<Student>();
            while (res.Read())
            {
                lst.Add(new Student() { Sid =res.GetInt32(res.GetOrdinal("Sid")), Sname = res.GetString(res.GetOrdinal("Sname")), Semail = res.GetString(res.GetOrdinal("Semail")), Spassword = res.GetString(res.GetOrdinal("Spassword")), Departments_Did = res.GetInt32(res.GetOrdinal("Departments_Did"))});
            }
             

            con.Close();
            return lst;
        }
        public DataTable SelectAll()
        {
            con.Open();
             SqlDataAdapter cmd = new SqlDataAdapter("select S.Sid,S.Sname,S.Semail,S.Spassword,S.Departments_Did,D.Did,D.Dname from students as S inner join departments as D on S.Departments_Did=D.Did", con);
            //SqlCommand cmd = new SqlCommand("select * from students", con);

            DataTable dt = new DataTable();
            cmd.Fill(dt);
            con.Close();
            return dt;

             
        }
        public bool Selectbyid(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from students where Sid='"+id+"'", con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();

            if (v > 0)
            {
                return false; ;
            }
            else
            {
                return true;
            }


         }
        public bool Selectdeptid(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from departments where Did='" + id + "'", con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();

            if (v > 0)
            {
                return true; ;
            }
            else
            {
                return false;
            }


        }

        public void Remove(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete  from Students where Sid='"+id+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            return;

        }

    }
}