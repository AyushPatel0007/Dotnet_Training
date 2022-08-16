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
    
    public class ProductService
    {
        Connect c = new Connect();
        SqlConnection con = new SqlConnection();
        public DataTable DisplayProduct()
        {
            DataTable dt = new DataTable();

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Product", con);
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
        public bool InsertProduct(Product p)
        {
            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Product values('" + p.Pname + "','"+p.Price+"','"+p.Cid+"')", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("--------------Executed-----------------");

                }
                else
                {
                    Console.WriteLine("-----------Not---Executed-----------------");
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
        public bool DeleteProduct(int id)
        {
            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Product where Pid='" + id + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("--------------Executed-----------------");

                }
                else
                {
                    Console.WriteLine("-----------Not---Executed-----------------");
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
        public bool UpdatebyName(int i,string name)
        {

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Product Set Pname='" + name + "' where Pid='" + i + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("--------------Executed-----------------");

                }
                else
                {
                    Console.WriteLine("-----------Not---Executed-----------------");
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
        public bool UpdatebyPrice(int i, int price)
        {

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Product Set Price='" + price + "' where Pid='" + i + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("--------------Executed-----------------");

                }
                else
                {
                    Console.WriteLine("-----------Not---Executed-----------------");
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
        public bool UpdatebyCategoryId(int i, int cid)
        {

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Product Set Cid='" + cid + "' where Pid='" + i + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("--------------Executed-----------------");

                }
                else
                {
                    Console.WriteLine("-----------Not---Executed-----------------");
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

        public DataTable DisplayAll()
        {
            DataTable dt = new DataTable();

            try
            {
                con = c.SqlConnection2();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select P.Pid,C.Cid,C.Cname,P.Pname,P.Price from Product as P full outer join Category as C on P.Cid=C.Cid", con);
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

    }
}
