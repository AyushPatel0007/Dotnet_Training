using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string usertype = "seeker";
                SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
                string s = "seeker";
                // SqlCommand cmd = new SqlCommand("Select * from users where Usertype='"+"seeker+"'", con);
                SqlCommand cmd = new SqlCommand("Select * from users where Usertype=@us and id>@ii", con);

                con.Open();
                cmd.Parameters.Add(new SqlParameter("@us", s));
                cmd.Parameters.Add(new SqlParameter("ii", 3));

                SqlDataReader sq = cmd.ExecuteReader();
                while (sq.Read())
                {
                    Console.WriteLine(sq["Emailid"] + " " + sq["Name"]);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
