using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_linq
{
    class Student { 
        public  int id { get; set; }

        public string name { get; set; }
        public string gender { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>() {
            new Student(){id=1,name="Lucky",gender="male"},
                new Student(){id=2,name="Jospeh",gender="male"},
                new Student(){id=3,name="Sandy",gender="male"}
         };


            //Linq using query

            IEnumerable<Student> querystk = from s in st
                                            select s;
            foreach(var obj in querystk)
            {
                Console.WriteLine(obj.id +"  "+obj.name+" "+obj.gender);
            }
            //Linq using method 

            IQueryable<Student> queryst = st.AsQueryable();
            foreach (var obj in queryst)
            {
                Console.WriteLine(obj.id + "  " + obj.name + " " + obj.gender);
            }

            IEnumerable<Student> querys = st.ToList();
            foreach (var obj in querys)
            {
                Console.WriteLine(obj.id + "  " + obj.name + " " + obj.gender);
            }



        }
    }
}
