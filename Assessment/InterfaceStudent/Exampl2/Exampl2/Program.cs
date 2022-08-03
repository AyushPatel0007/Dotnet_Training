using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampl2

{
    class MyException : Exception
    {
        public void MyWrongException()
        {
            Console.WriteLine("UnWanted number selected");
        }

    }

    class Program
    {
        public static Student[] array = new Student[0];



        static void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Student Profile");
            Console.WriteLine("Enter 2: To Update Details of Students ");
            Console.WriteLine("Enter 3: To Display Details of Students ");
            Console.WriteLine("Enter 4: To Delete Details of Students ");

            Console.WriteLine("press 5: EXIT");
        }

        static Boolean Process(byte choice)
        {
            try
            {
                if (choice > 5)
                {
                    throw new MyException();
                }

            }
            catch (MyException e)
            {
                e.MyWrongException();

            }

            Methods m1 = new Methods();

            switch (choice)
            {
                case 1:
                    array = m1.DynamicArray(array);
                    array = m1.createContact(array);
                    return true;

                case 2:
                    int k=m1.Idupdate();
                    m1.Update(array,k);
                    //Display(array);
                    return true;

                case 3:
                    m1.Display(array);
                    return true;

                case 4:
                    int m = m1.Iddelete();
                    m1.Delete1(array,m);
                    return true;
                case 5:
                    return false;

                default:
                    Console.WriteLine("Thank You for using us" + "");
                    Console.WriteLine();
                    return true;

            }


        }
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                DisplayMenu();
                Console.WriteLine();
                Console.WriteLine("Please Enter Your Choice");

                byte choice = byte.Parse(Console.ReadLine());
                flag = Process(choice);
            } while (flag);
        }
    }
}