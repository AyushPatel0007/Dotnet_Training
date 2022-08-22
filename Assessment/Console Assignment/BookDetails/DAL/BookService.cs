using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class BookService:Interface1
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");

        public string InsertData(int id, string name, string author, string publisher, int price)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("Select count(*) from BookDetails where Bookid='" + id + "'", con);
                
                SqlCommand cmd = new SqlCommand("InsertBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bookid", id));
                cmd.Parameters.Add(new SqlParameter("@Bookname", name));
                cmd.Parameters.Add(new SqlParameter("@Author", author));
                cmd.Parameters.Add(new SqlParameter("@Publisher", publisher));
                cmd.Parameters.Add(new SqlParameter("@Price", price));
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                return "***Not Executed****";
            }

            return "***Executed****";



        }

        public object DisplayData()
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SelectBook", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();

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

        public string UpdateData(int id, string name, string author, string publisher, int price)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bookid", id));
                cmd.Parameters.Add(new SqlParameter("@Bookname", name));
                cmd.Parameters.Add(new SqlParameter("@Author", author));
                cmd.Parameters.Add(new SqlParameter("@Publisher", publisher));
                cmd.Parameters.Add(new SqlParameter("@Price", price));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return "***Not Executed****";
            }

            return "***Executed****";



        }
        public string DeleteData(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));
                 
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return "***Not Executed****";
            }

            return "***Executed****";



        }

    }
    
}
