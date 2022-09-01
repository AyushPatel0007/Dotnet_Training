using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            List<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="High"},
                new Standard(){ StandardID = 2, StandardName="Medium"},
                new Standard(){ StandardID = 3, StandardName="Low"}
            };

            var res = studentList.GroupBy(x => x.StandardID);
            foreach(var r in res)
            {
                Console.WriteLine(r.Key + " ");
                foreach (var k in r)
                {
                    Console.WriteLine(k.StudentName);
                }
                
                Console.WriteLine();
            }

            var innerJoin = from e in studentList
                            join p in standardList
                            on e.StandardID equals p.StandardID
                            select new
                            {
                                Student = e.StudentName,
                                Standard = p.StandardName
                            };


            foreach(var r in innerJoin)
            {
                Console.WriteLine(r.Student + " " + r.Standard);
                    Console.WriteLine(); 
            }

 
            var innerJoin1 = studentList.Join(standardList, str1 => str1.StandardID, str2 => str2.StandardID, (str1, str2) => new{ StudentName = str1.StudentName,Standardname = str2.StandardName});

            foreach (var r in innerJoin1)
            {
                Console.WriteLine(r.StudentName + " " + r.Standardname);
                Console.WriteLine();
            }
        }
    }
}
