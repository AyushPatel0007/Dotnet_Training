using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"<?xml version=""1.0""?>
                        <country name=""india"">
                            <capital>delhi</capital>
                        </country>";

            XDocument xdoc = XDocument.Parse(str, LoadOptions.PreserveWhitespace);
            Console.WriteLine(xdoc);
            Console.ReadLine();
        }
    }
}
