using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL
{
    public class CategoryService:Interface2
    {
        
        SqlConnection con = new SqlConnection();
        Connect c = new Connect();
   
        public bool InsertCategory(Category e)
        {
            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Category values('" + e.Cname + "')", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
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


        public DataTable DisplayCategory()
        {
            DataTable dt = new DataTable();

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Category", con);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return dt;
        }


        public bool DeleteCategory(int id)
        {
            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Category where Cid='" + id + "'", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
 
            }catch(Exception e)
            {
                
                Console.WriteLine("---Foreign key Exception-----\n"+e.Message);
                return true;
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
        public bool UpdateCategory(int id,string s)
        {
            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Category set Cname='"+s+"' where Cid='"+id+"'", con);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
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

    }
}
