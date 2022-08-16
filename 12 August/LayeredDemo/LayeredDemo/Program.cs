using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Operations;

namespace LayeredDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EStudent stu = new EStudent();
            //stu.Sname = Console.ReadLine();
            //stu.Semail = Console.ReadLine();
            //stu.Spassword = Console.ReadLine();
            //stu.Departments_Did = int.Parse(Console.ReadLine());
            OStudent op = new OStudent();
            //op.InsertStudent(stu);
           SqlDataReader res= op.SelectStudent();
            while (res.Read())
            {
                Console.WriteLine(res["Sname"]);
            }
        }
    }
}
