using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTableAdo
{
    internal class StudentService
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");
        public void SelectUser()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select s.Sid,s.Sname,d.Dname from Students as s left outer join Departments as d on d.Did=s.Departments_Did", con);
                var res = cmd.ExecuteReader();
                foreach (var r in res)
                {
                    Console.WriteLine(res[0] + " " + res[1] + " " + res[2]);
                }
                Console.WriteLine("------------------------------------");

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
             
           
           
        }
        public bool SelectDepartment()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select d.Did,d.Dname from   Departments as d ", con);
                var res = cmd.ExecuteReader();
                foreach (var r in res)
                {
                    Console.WriteLine(res[0] + " " + res[1]);
                }
                Console.WriteLine("------------------------------------");

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
        public bool SelectStudent()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select s.Sid,s.Sname,s.Departments_Did  from Students as s", con);
                var res = cmd.ExecuteReader();
                foreach (var r in res)
                {
                    Console.WriteLine(res[0] + " " + res[1] + " " + res[2]);
                }
                Console.WriteLine("------------------------------------");

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

        public bool DeleteStudent()
        {
            
            try {
                con.Open();
                Console.WriteLine("Enter id: ");
                int n = int.Parse(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("delete from students where Sid='"+n+"'", con);
                 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Deleted");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not deleted");
                    Console.WriteLine("------------------------------------");

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

        public bool InsertStudent()
        {
            try
            {
                con.Open();
                Console.WriteLine("Enter name:");
                string s = Console.ReadLine();
                Console.WriteLine("Enter gmail:");
                string k = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string d = Console.ReadLine();
                Console.WriteLine("Enter Dept Id :");
                int h = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("insert into students values('"+s+ "','" + k + "','" + d + "','" + h + "')",con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("insert student");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not inserted");
                    Console.WriteLine("------------------------------------");

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
        public bool UpdateStudent()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update   students set Sname='"+"manan"+"' where Sid='"+5+"'",con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Update student");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not inserted");
                    Console.WriteLine("------------------------------------");

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
        public bool DeleteDepartment()
        {
            try
            {
                con.Open();
                Console.WriteLine("Enter id: ");
                int n = int.Parse(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("delete from departments where Did='" + n + "'", con);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Deleted");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not deleted");
                    Console.WriteLine("------------------------------------");

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

        public bool Insertdepartment()
        {
            try
            {
                con.Open();
                Console.WriteLine("Enter dept name: ");
                string s = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("insert into Departments values('" + s + "')", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("insert department");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not inserted");
                    Console.WriteLine("------------------------------------");

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
        public bool UpdateDepartment()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update student Departments set Dname='" + "Doctor" + "' where Did='" + 4 + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Update department");
                    Console.WriteLine("------------------------------------");

                }
                else
                {
                    Console.WriteLine("Not inserted");
                    Console.WriteLine("------------------------------------");

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
