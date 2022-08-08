using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practise2
{
    class Dept
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

    }
    class Dept1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dept[] str =
           {
                    new Dept(){id=1,name="Cse",location="indore"},
                    new Dept(){id=2,name="Ec",location="punjab"},

                    new Dept(){id=3,name="ee",location="haryana"},

                    new Dept(){id=4,name="law",location="kolkata"},

                    new Dept(){id=5,name="poltics",location="Up"},

                    new Dept(){id=6,name="poltics",location="Up"}
            };

            bool sele = str.All(x=>x.id>0);
            Console.WriteLine(sele);
           Dept1[] strr =
           {
                new Dept1(){id=1,name="Cse1",location="indore1"},
                new Dept1(){id=1,name="Ec1",location="punjab1"},
                new Dept1(){id=1,name="ee1",location="haryana1"},
                new Dept1(){id=2,name="law2",location="kolkata2"},
                new Dept1(){id=2,name="poltics1",location="Up2"},
                new Dept1(){id=4,name="poltics1",location="Up4"}
            };


            //var k1 = strr.Join(str, st => st.id, st1 => st1.id, (st, st1) => new {st=st1.name,st1=st1.location});

            //foreach(var obj in k1)
            //{
            //    Console.WriteLine(obj.st+" "+obj.st1);

            //}



            //var joi = str.GroupJoin(strr, st => st.id, st1 => st1.id, (a, b) => new
            //{
            //   a,b
            //});

            //foreach(var obj in joi)
            //{
            //    Console.WriteLine(obj.a.id);
            //    foreach(var obj1 in obj.b)
            //    {
            //        Console.WriteLine(obj1.location);
            //    }
            //}
            

        }
    }
}
