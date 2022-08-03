using System;

namespace EnumDemo
{
    class Program
    {
        enum week {
        monday,tuesday,wednesday,thrusday,friday,saturday, sunday
        }
        enum color { 
        red=1,blue=2,yellow=3}
        enum dept
        {
            cse=1,ec=2,eee=2
        }


        static void Main(string[] args)
        {
            Console.WriteLine((int)week.monday);

            Console.WriteLine((int)week.saturday);
            Console.WriteLine(color.yellow + " "+(int)color.yellow);
        }
    }
}
