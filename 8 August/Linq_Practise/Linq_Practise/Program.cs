using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practise
{
    class Dept
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location{ get; set; }

    }
    class class1
    {
        public int id { get; set; }
        public string value { get; set; }

    }
    class class2
    {
        public int id { get; set; }
        public string childvalue { get; set; }

    }
    class Student
    {
        public int id { get; set; }
        public int age { get; set; }

        public string name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "abhi", "ankit", "anmol", "jatin" };
            var name=from s in names
                     where s.Contains('i')
                    select s;

            foreach(string obj in name)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------Using Contains----------------------------");


            var namek = names.Where(s => s.Contains('i'));
            foreach (string obj in namek)
            {
                Console.WriteLine(obj);
            }


            Student[] starr =
            {
                new Student(){id=1,name="amit",age=19},
                new Student(){id=2,name="ankit",age=20},

                new Student(){id=3,name="abhi",age=29},

                new Student(){id=4,name="sandy",age=12},

                new Student(){id=5,name="anmol",age=19},


            };


            foreach (Student st in starr)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.age);
            }


            Student[] teens = starr.Where(x => x.age > 12 && x.age < 19).ToArray();
            Student bill = starr.Where(s => s.name == "sandy").FirstOrDefault();

            Console.WriteLine("----------------------Sorting Ascending----------------------------");

            var sortlist = starr.OrderBy(s => s.age);

            foreach (Student st in sortlist)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.age);
            }
            Console.WriteLine("----------------------Sorting Ascending and then b----------------------------");

           sortlist = starr.OrderBy(s => s.age).ThenBy(s=>s.name);

            foreach (Student st in sortlist)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.age);
            }


            Console.WriteLine("----------------------Sorting descending----------------------------"); 
            var sortlistdesc = starr.OrderByDescending(s => s.age);

            foreach (Student st in sortlistdesc)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.age);
            }
            Console.WriteLine("----------------------Group by----------------------------");
            var sortlistesc =  starr.GroupBy(s => s.age);

            foreach (var st in sortlistesc)
            {
                Console.WriteLine("age group: {0}",st.Key);
                foreach(Student s in st)
                    Console.WriteLine("Student Name: {0}", s.name.ToString());
                Console.WriteLine();

            }



            Console.WriteLine("----------------------Oftype----------------------------");

            IList lst = new ArrayList() { 1, "ayush", 9, "male" };
            var onlyString = lst.OfType<int>();
            foreach(var v in onlyString)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("----------------------Join---------------------------");
            IList<string> str1 = new List<string>() { "one", "two", "three", "four" };
            IList<string> str2 = new List<string>() { "one", "two", "five", "six" };
            var innerjoin = str1.Join(str2, st1 => st1, st2 => st2 ,(st1, st2) => st1);
            foreach(string s in innerjoin)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------------Group Join---------------------------");
            List<class1> strr1 = new List<class1>() { 
            new class1(){id=1,value="a"},
            new class1(){id=2,value="b"},

            new class1(){id=3,value="c"},


            };

            List<class2> strr2 = new List<class2>() {
            new class2(){id=1,childvalue="a1"},
            new class2(){id=1,childvalue="a2"},

            new class2(){id=2,childvalue="b1"},
            new class2(){id=2,childvalue="b2"},
            new class2(){id=4,childvalue="d"},
            };


            var groupjoin = strr1.GroupJoin(strr2, st1 => st1.id, st2 => st2.id,
                                            (value, childvalues) => new { value = value, childvalues = childvalues });
            foreach(var s in groupjoin)
            {
                Console.WriteLine(s.value.value);
                foreach(var v in s.childvalues)
                    Console.WriteLine(v.childvalue);

            }





            Console.WriteLine("---------------------select---------------------------");
            var res = starr.Select(s => new { studentname = s.name, age = s.age }).Where(s => s.age > 19);
            foreach(var s in res)
            {
                Console.WriteLine(s.studentname);
                Console.WriteLine(s.age);
            }

            Console.WriteLine("---------------------selectMany---------------------------");


            var rres = starr.SelectMany(s => s.name).ToList();
            foreach (var s in rres)
            {
                Console.WriteLine(s.ToString());
              
            }

            bool areAllStudent = starr.All(s => s.age > 12 && s.age < 20);
            Console.WriteLine(areAllStudent);


            bool areAllStudent2 = starr.Any(s => s.age > 12 && s.age < 20);
            Console.WriteLine(areAllStudent2);


            Student std = new Student() { id = 2, name = "harsh"};
            Console.WriteLine(starr.Contains(std));

            var sp = starr.FirstOrDefault(s => s.name.Contains('a'));
            Console.WriteLine(sp.name);


            var sp1 = starr.LastOrDefault(s => s.name.Contains('a'));
            Console.WriteLine(sp1.name);


            int spe = starr.Count(s => s.age > 12);
            Console.WriteLine(spe);

            Console.WriteLine("--------------------------------------------------------------------");
            Dept[] str =
            {
                new Dept(){id=1,name="Cse",location="indore"},
                new Dept(){id=2,name="Ec",location="punjab"},

                new Dept(){id=3,name="ee",location="haryana"},

                new Dept(){id=4,name="law",location="kolkata"},

                new Dept(){id=5,name="poltics",location="Up"},

                 new Dept(){id=6,name="poltics",location="Up"},


            };
            var k = str.Select(s => s.name).GroupBy(s=>s.name);




















        }
    }
}
