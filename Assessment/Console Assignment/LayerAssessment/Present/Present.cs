using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;

namespace Present
{
    public class Presents
    {
        CategoryIO C = new CategoryIO();
        ProductIO P = new ProductIO();
        public bool CMenu()
        {
            bool flag = true;
            int n;
            test1:
            while (flag)
            {
                try
                {

                    Console.WriteLine("1:Insert\n2:Display\n3:Delete\n4:Update\n5:Display All\nOther:Exit");
                    Console.Write("Enter choice: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid");
                    goto test1;
                }

                Console.WriteLine("------------------------------------------");
                switch (n)
                {
                    case 1:
                        flag = C.Insert();
                        break;
                    case 2:
                        DataTable dt = C.Display();
                        
                        Console.WriteLine("---------------------Table Data--------------------------------");
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                Console.Write(row[column] + " | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("------------------------------------");

                        flag = true;
                        break;
                    case 3:                        
                        flag = C.Delete();
                        break;
                    case 4:
                       flag = C.Update();
                        break;
                    case 5:
                        DataTable dtt = P.DisplayAl();
                        Console.WriteLine("---------------------Table Data--------------------------------");
                        foreach (DataRow row in dtt.Rows)
                        {
                            foreach (DataColumn column in dtt.Columns)
                            {
                                Console.Write(row[column] + " | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("------------------------------------");

                        flag = true;
                        break;

                    default: flag = false; break;


                }
            }
            return true;
        }


        public bool PMenu()
        {
            bool flag = true;
            int n;
            test1:
            while (flag)
            {
                try
                {

                    Console.WriteLine("1:Insert\n2:Display\n3:Delete\n4:Update\n5:Display All\nOther:Exit\n Enter Choice: ");
                    Console.Write("Enter choice: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------------------");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("--------------Invalid Format------------");
                    goto test1;
                }

                 switch (n)
                {
                    case 1:
                        flag = P.Insert();
                        break;
                    case 2:
                        DataTable dt = P.Display();
                        Console.WriteLine("---------------------Table Data--------------------------------");
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                Console.Write(row[column] + " | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("------------------------------------");

                        flag = true;
                        break;
                    case 3:
                        flag = P.Delete();
                        break;
                    case 4:
                        flag = P.Update();
                        break;
                    case 5:
                        DataTable dtt = P.DisplayAl();
                        Console.WriteLine("---------------------Table Data--------------------------------");
                        foreach (DataRow row in dtt.Rows)
                        {
                            foreach (DataColumn column in dtt.Columns)
                            {
                                Console.Write(row[column] + " | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("------------------------------------");

                        flag = true;
                        break;

                    default: flag = false; break;


                }
            }
            return true;
        }

        
    }
}
