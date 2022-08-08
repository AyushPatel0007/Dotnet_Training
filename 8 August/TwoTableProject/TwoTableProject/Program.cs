using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            Connection C = new Connection();
            con = C.Connections();
            con.Open();
            SqlCommand cmd=new SqlCommand("Update Student set Name='"+"lucky"+"' where ID='"+1+"'",con);
            if (cmd.ExecuteNonQuery() >= 1)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Not done");
            }
        }
    }
}
