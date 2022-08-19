using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL;

namespace BAL
{
    public class ProductIO:ProductInterface
    {
        ProductService d = new ProductService();
        public DataTable Display()
        {
            

            return d.DisplayProduct();

        }
        public DataTable DisplayAl()
        {

            return d.DisplayAll();

        }


        public bool Insert()
        {
            test1:
            try
            {
                
                Console.Write("Enter the name: ");
                string n = Console.ReadLine();
                Console.Write("Enter the Price");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Course ID: ");
                int C = int.Parse(Console.ReadLine());
                Product pro = new Product()
                {
                    Pname = n,
                    Price = p,
                    Cid = C
                };
                d.InsertProduct(pro);
            }
            catch(Exception ex)
            {
                Console.WriteLine("---------Course Id not present-----------",ex.Message);
               goto test1;
            }
            return true;

        }

        public bool Delete()
        {
            try
            {
                Console.Write("Enter id: ");
                int mm = int.Parse(Console.ReadLine());
                if (d.DeleteProduct(mm))
                {
                    Console.WriteLine("-----------Executed--------------");
                }
                else
                {
                    Console.WriteLine("---------Not--Executed--------------");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }


        public bool Update()
        {
            test1:
            try
            {
                Console.WriteLine("Enter the id");
                int i= int.Parse(Console.ReadLine());

                Console.WriteLine("\n1:Update by Product Name\n2:Update by Price \n3:Update by Course Id\nEnter Choice: ");
                int n = int.Parse(Console.ReadLine());
                 switch (n) {
                    case 1:
                        Console.Write("Enter the Product Name:");
                        string s = Console.ReadLine();
                        d.UpdatebyName(i, s); break;
                    case 2:
                        Console.Write("Enter the Price:");
                        int p = int.Parse(Console.ReadLine());
                        d.UpdatebyPrice(i, p); break;

                    case 3:
                        Console.Write("Enter the Category Id:");
                        int ci = int.Parse(Console.ReadLine());
                        d.UpdatebyPrice(i, ci); break;
                    default: break;
                
                }
                throw new Myexception();


            }
            catch (FormatException ex)
            {
                Console.WriteLine("---------Invalid Enter--",ex.Message);
            }
            catch (Myexception e)
            {
                e.InvaildEnter();
                goto test1;
            }
            return true;
        }
    }
}
