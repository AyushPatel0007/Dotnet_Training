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
            var st = from element in xele.Descendants("Customer")
                     select new
                     {
                         custid = element.Attribute("id").Value,
                         custname = element.Attribute("name").Value
                     };
            foreach(var s in st)
            {
                Console.Write(s.custid);
                Console.WriteLine(s.custname);

            }

        }
    }
}
