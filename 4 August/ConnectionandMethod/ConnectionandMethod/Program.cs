using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionandMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
            try
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from users", con);

                // SqlCommand cmd = new SqlCommand("Insert into users values('"+"Ayush"+ "','" + 9087 + "','" + "z@gmail.com" + "','" + "abc" + "','" + "Ayush" + "','" + "Ayush" + "')", con);
              // SqlCommand cmd = new SqlCommand("delete  from Users where Id='"+9+"'", con);

                SqlCommand cmd = new SqlCommand("Update users set Emailid='" + "k@gmail.com" + "' where id='" + 8 + "'");
                SqlDataReader rd = null;
                int a = cmd.ExecuteNonQuery();
                if (a >= 1)
                {
                    Console.WriteLine("Executed");
                }
                else
                {
                    Console.WriteLine("Not executed");
                }

                //rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    Console.WriteLine(rd["Emailid"]);
                //}

            }
            finally
            {
             if(con!=null)    
              con.Close();
                
            }

        }
    }
}
