using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyAppDb.Operation
{
    public class MyService
    {
        public void AddStudent(StudentModel Stu)
        {
            using(var con =new DbEntities())
            {
                Student st = new Student() {
                    Sid = Stu.Sid,Sname=Stu.Sname,Semail=Stu.Semail,Spassword=Stu.Spassword,Departments_Did=Stu.Departments_Did
                };
                con.Students.Add(st);
                con.SaveChanges();            


            }
        }
    }
}
