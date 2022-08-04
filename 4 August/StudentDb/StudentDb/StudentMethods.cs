using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal class StudentMethods:Connection,StudentInterface
    {
        SqlConnection con;
        public StudentMethods()
        {
            con = Connections();
        }
        public bool Insert()
        {
            try
            {
                con.Open();
                Console.WriteLine("Enter the Name");
                string n = Console.ReadLine();
                Console.WriteLine("Enter the Marks");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Address");
                string a = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("Insert into student values('" + n + "','" + m + "','" + a + "')", con);
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
        public bool Display()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Student", con);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                dp.Fill(dt,"Student");

              Console.WriteLine("---------------------Table Data--------------------------------");
                foreach(DataColumn col in dt.Tables[0].Columns)  
                {
                    Console.Write(col.ColumnName + " | ");
                }
                Console.WriteLine();

 

                foreach (DataRow row in dt.Tables["Student"].Rows)
                {
                    foreach(DataColumn column in dt.Tables["Student"].Columns)
                    {
                        Console.Write(row[column]+" | ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("-----------------------------------------------------");
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
        public bool Update(int i)
        {
            try
            {
                con.Open();
                Console.WriteLine("1: Update Name  2:Update Marks   3:Address");
                Console.Write("Enter Choice: ");

                int n = int.Parse(Console.ReadLine());

                int a=0;
                SqlCommand cmd = null;
                switch (n) {

                    case 1:
                        Console.WriteLine("Name: ");
                        string nam = Console.ReadLine();
                        cmd = new SqlCommand("updatename", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", i));
                        cmd.Parameters.Add(new SqlParameter("@name", nam));
                        a = cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        Console.WriteLine("Marks: ");
                        int ma  = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("updatemarks", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", i));
                        cmd.Parameters.Add(new SqlParameter("@marks", ma));
                        a = cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        Console.WriteLine("Address: ");
                        string ad = Console.ReadLine();
                        cmd = new SqlCommand("updateaddress", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", i));
                        cmd.Parameters.Add(new SqlParameter("@address", ad));
                        a = cmd.ExecuteNonQuery();
                        break;
                    
                    default:break;

                }
                if (a >= 1)
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
        
        public bool Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(Id) from Student", con);
                int a = (int)cmd.ExecuteScalar();
                Console.WriteLine("Number of Row :{0}",a);
                Console.WriteLine("-----------------------------------------");

            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return true;
        }
    }
}
