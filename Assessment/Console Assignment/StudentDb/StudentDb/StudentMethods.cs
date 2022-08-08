using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal class StudentMethods:Connection ,StudentInterface
    {
        SqlConnection con;
        public StudentMethods()
        {
           con = Connections();
             
        }
        public bool Insert(List<StudentVar> st)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into student values('" + st[0].Name + "','" + st[0].Marks + "','" + st[0].Address + "')", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    Console.WriteLine("Inserted Successfully");
                    Console.WriteLine("----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Not Executed");
                }

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return true;

        }
        public List<StudentVar> Display()
        {
            List<StudentVar> stu = new List<StudentVar>();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Student", con);
                SqlDataReader sq = cmd.ExecuteReader();

                Console.WriteLine("---------------------Table Data--------------------------------");
                while (sq.Read())
                {
                    stu.Add(new StudentVar(Convert.ToInt32(sq["Id"]), sq["Name"].ToString(), Convert.ToInt32(sq["Marks"]), sq["Address"].ToString()));
                     
                }
                 
            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return stu;
        }
        public bool Delete(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Student where Id='"+id+"'", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    Console.WriteLine("Delete Successfully");
                    Console.WriteLine("----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Not Deleted");
                }

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return true;
        }
        public bool Update(List<StudentVar> st)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Student set Name='" + st[0].Name + "',Marks='" + st[0].Marks + "',Address='" + st[0].Address + "' where Id='" + st[0].id + "'", con);
                if(cmd.ExecuteNonQuery()>= 1)
                {
                    Console.WriteLine("Updated");
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    Console.WriteLine("Not Updated");
                }


            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return true;
        }
        
        public int Count()
        {
            int a=0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(Id) from Student", con);
                a= (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return a;
        }
    }
}
