using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampl2
{
    public class Methods : Interface1, Interface2, Interface3
    { 

        #region update
        public Student[] Update(Student[] array,int uid)

        {
             

            int res = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (uid == array[i].GetID())
                {
                    res = i;
                }
            }
            try
            {
                if (res == -1)
                    throw new MyException();
            }
            catch (MyException ex)
            {
                ex.MyWrongException();
                return array;
            }

            Console.WriteLine("Enter 1. To Update the the Id ");
            Console.WriteLine("Enter 2. To Update the the Name ");
            Console.WriteLine("Enter 3. To Update the the Total Marks ");
            Console.WriteLine("Enter 4. To Update the the Address ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
 
            try
            {
                if (n > 4)
                {
                    throw new MyException();
                }

            }
            catch (MyException e)
            {
                e.MyWrongException();


            }
            

            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter Your Id");
                    int p = int.Parse(Console.ReadLine());
                    array[res].SetId(p);
                    break;

                case 2:
                    Console.WriteLine("Enter Your Name");
                    string s = Console.ReadLine();
                    array[res].SetName(s);
                    break;

                case 3:
                    Console.WriteLine("Enter Your Marks");
                    int m = int.Parse(Console.ReadLine());
                    array[res].SetMarks(m);
                    break;

                case 4:
                    Console.WriteLine("Enter Your Address");
                    string s1 = Console.ReadLine();
                    array[res].SetAddress(s1);
                    break;

                default:
                    Console.WriteLine("Thank You for updating information");
                break;
            }
            return array;
        }

        #endregion

        public void Delete1(Student[] array,int uid)
        {
            int res = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (uid == array[i].GetID())
                {
                    res = i;
                }
            }
            try
            {
                if (res == -1)
                    throw new MyException();
            }
            catch(MyException ex)
            {
                ex.MyWrongException();
                return;
            }

            array[res].SetAddress(null);
            array[res].SetId(0);
            array[res].SetMarks(0);
            array[res].SetName(null);


        }

        public Student[] createContact(Student[] arr)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Please Enter the Student Information ");
            Console.WriteLine();
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {

                arr[i] = new Student();
                Console.WriteLine("Enter the  Id : ");
                int id = int.Parse(Console.ReadLine());
                arr[i].SetId(id);

                Console.WriteLine("Enter the Student Name :");
                String name = Console.ReadLine();
                arr[i].SetName(name);
               
                Console.WriteLine("Enter the marks :");
                int marks = int.Parse(Console.ReadLine());
                arr[i].SetMarks(marks);
                Console.WriteLine("Enter the  city:  ");
                string address = Console.ReadLine();
                arr[i].SetAddress(address);

            }
            return arr; 
        }

        public Student[] DynamicArray(Student[] arr)
        {
            Student[] temp = new Student[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        public void Display(Student[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetName() + "   " + arr[i].GetID() + "   " + arr[i].GetMarks() + "   " + arr[i].GetAddress());
            }
            Console.WriteLine();
        }
        public int Idupdate()
        {
             
                Console.WriteLine("Enter Id");
                 return int.Parse(Console.ReadLine());
        }
        public int Iddelete()
        {

            Console.WriteLine("Enter Id");
            return int.Parse(Console.ReadLine());
        }


    }

}
