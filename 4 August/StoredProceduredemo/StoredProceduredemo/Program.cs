using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProceduredemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Without Parameter---------------------------");
            RunWtotParameter();
            Console.WriteLine("--------------------With Parameter---------------------------");
            RunWtParameter("seeker");



        }
        public static void RunWtotParameter()
        {
            SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("getData", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sq = cmd.ExecuteReader();
            while (sq.Read())
            {
                Console.WriteLine(sq["Emailid"]);
            }
        }
        public static void RunWtParameter(string str)
        {
            SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("getUsertype1", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.Add(new SqlParameter("@User",str));
            cmd.Parameters.Add(new SqlParameter("@country", "India"));
            SqlDataReader sq = cmd.ExecuteReader();
            while (sq.Read())
            {
                Console.WriteLine(sq["Emailid"]+" " + sq["Usertype"]);
            }
        }
    }
}
