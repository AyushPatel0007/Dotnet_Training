using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Getuser();
            //AddUser();
            
            //DeleteUser();
           
            //UpdateUser();
            Getuser();
        }


        public static void AddUser()
        {
            using(var con=new UserEntities())
            {
                con.Students.Add(new Student()
                { Sname="Lucky",
                  Semail="luck@gmail.com",
                  Departments_Did=4,
                  Department=new Department()
                  {
                      Did=4,
                      Dname="Ec"
                  }
                });
                if (con.SaveChanges() > 0)
                {
                    Console.WriteLine("Successfull added");
                }
                else
                {
                    Console.WriteLine("Not Added");
                }
            }
        }

        public static void DeleteUser()
        {
            using(var con=new UserEntities())
            {
                var res = con.Students.SingleOrDefault(x => x.Sid == 3);
                con.Students.Remove(res);
                if (con.SaveChanges()>0)
                {
                    Console.WriteLine("Deleted");
                }
                else
                {
                    Console.WriteLine("Not deleted");
                }
            }
        }
    
       public static void UpdateUser()
       {
            using(var con=new UserEntities())
            {
                var res = con.Students.SingleOrDefault(x => x.Sid == 4);
                res.Sname = "Ayush";
                res.Department.Dname = "cse";
                if (con.SaveChanges() > 0)
                {
                    Console.WriteLine("updated");
                }
                else
                {
                    Console.WriteLine("not updated");
                }
            }
       }
    
        public static void Getuser()
        {
            using(var con=new UserEntities())
            {
                var res = con.Students;
                foreach(var r in res)
                {
                    Console.WriteLine("Student Id: "+r.Sid+" |Student Name "+r.Sname+" "+ " |Department Name " + r.Department.Dname );
                }
            }
        }
    }
}
