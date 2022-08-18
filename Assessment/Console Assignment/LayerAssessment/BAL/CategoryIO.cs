using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entity;

namespace BAL
{
    public class CategoryIO: CategoryInterface
    {
        CategoryService d = new CategoryService();

        public bool Insert()
        {
            try
            {


                Console.WriteLine("Enter the Course Name");
                string n = Console.ReadLine();
                List<Category> lst = new List<Category>();
                lst.Add(new Category(n));
                Category c = new Category() { Cname=n };

                if (d.InsertCategory(c))
                {
                    Console.WriteLine("-----------Executed---------");
                }
                else
                {
                    Console.WriteLine("---------Not--Executed---------");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;

        }
        public DataTable Display()
        {

            return d.DisplayCategory();


        }
        public bool Delete()
        {
            try
            {
                Console.Write("Enter id: ");
                int mm = int.Parse(Console.ReadLine());
                if (d.DeleteCategory(mm))
                {
                    Console.WriteLine("-----------Executed--------------");
                }
                else
                {
                    Console.WriteLine("---------Not--Executed--------------");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Format");
            }
            return true;
        }
        public bool Update()
        {
            step1:
            try
            {
                Console.Write("Enter id: ");
                int mm = int.Parse(Console.ReadLine());
                Console.WriteLine("Update name");
                string s = Console.ReadLine();

                if (d.UpdateCategory(mm,s))
                {
                    Console.WriteLine("-----------Executed--------------");
                }
                else
                {
                    Console.WriteLine("---------Not--Executed--------------");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input"+e.Message);
                goto step1;
            }
            return true;

        }
    }
}
