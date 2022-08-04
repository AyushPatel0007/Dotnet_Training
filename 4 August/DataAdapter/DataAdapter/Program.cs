using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
            try
            {
                SqlDataAdapter dk = new SqlDataAdapter("Select * from Users where id<3", con);

                SqlDataAdapter dp = new SqlDataAdapter("Select * from Users where id>3", con);
                //DataTable dt = new DataTable();
                //dp.Fill(dt);
                //foreach(DataRow row in dt.Rows)
                //{
                //    Console.WriteLine(row["Emailid"]);
                //}

                //DataSet ds = new DataSet();
                //dp.Fill(ds, "Users");
                //Console.WriteLine("------------Second Table Data---------");
                //Console.WriteLine("Count value is: "+ds.Tables.Count);
                //Console.WriteLine(ds.Tables[0].TableName);
                //foreach(DataRow row in ds.Tables["Users"].Rows)
                //{
                //   foreach(var i in row.ItemArray)
                //    {
                //        Console.Write(i);
                //    }
                //    Console.WriteLine("\n---------------------");
                // }



                //second one
                DataSet ds = new DataSet();
                dp.Fill(ds,"Users");
 

               // DataTable dt = ds.Tables["Users"];
                 

                foreach(DataRow row in ds.Tables["Users"].Rows)
                {
                    foreach (DataColumn col in ds.Tables["Users"].Columns)
                    {
                        Console.Write(row[col]);
                    }
                    Console.WriteLine();
                }













            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
