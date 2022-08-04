using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class Program
    {
        SqlConnection con;
        public Program()
        {
             con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");

        }
        public  void select()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users", con);

                SqlDataReader sq = cmd.ExecuteReader();
                while (sq.Read())
                {
                    Console.WriteLine(sq["Emailid"] + " " + sq["Name"]);
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void Insert()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users values('" + "ucky" + "','" + 907 + "','" + "ayu@gmail.com" + "','" + "ayu" + "','" + "seeker" + "','" + "india" + "')", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Not success");
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Users set Emailid='" + "Luck@gmail.com" + "' where id>'" + 6 + "'", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Not success");
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void delete()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Users where Id='" + 6 + "'", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Not success");
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public int Countval()
        {
            int c = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(Id) from users", con);
                c = (int)cmd.ExecuteScalar();

            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return c;
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.update();
            pr.select();
            Console.WriteLine(pr.Countval()) ;

        }
    }
}
