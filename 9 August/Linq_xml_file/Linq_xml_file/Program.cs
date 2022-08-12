using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_xml_file
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xele = XElement.Load(@"C:/Users/ayush.patel/Desktop/cust.xml");
            var dic = (from element in xele.Descendants("Department")  //data source and return collection as output
                       
                       select new
                       {
                           id = element.Attribute("id").Value,
                           name = (string)element.Attribute("name")
                       }).ToDictionary(n=>n.id,n=>n.name)
                       ;
            foreach(var obj in dic)
            {
                Console.WriteLine(obj.Key+" "+obj.Value);
            }


            Console.WriteLine( "--------------------");



            XElement xel = XElement.Load(@"C:/Users/ayush.patel/Desktop/f1.xml");

            var st = (from element in xel.Descendants("student1")
                      let id= (int)element.Element("id")
                      let name= (string)element.Element("name")
                      select new
                     {
                         custid =id,
                         custname = name
                     });

            int i = 0;

            foreach(var s in st)
            {
                i++;
                Console.WriteLine(s.custid+" "+s.custname);
 
            }
            

        }
    }
}
