using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static Laptop[] laptopArray = new Laptop[0];
        static void Main(string[] args)
        {
            Boolean f = true;
            do
            {
                DisplayMenu();
                Console.WriteLine("Please enter your choice");
                byte c = byte.Parse(Console.ReadLine());
                f=SelectionOperation(c);
            } while (f);

        }
        static void DisplayMenu()
        {
            Console.WriteLine("press 1: to add elemts");
            Console.WriteLine("press 2: to dispaly all elemts");
            Console.WriteLine("press 3: EXIT");
        }
        static Boolean SelectionOperation(byte Choice)
        {
            switch (Choice)
            {
                case 1:
                    laptopArray = DynamicArray(laptopArray);
                    laptopArray = AddElements(laptopArray);
                    return true;
                case 2:
                    Display(laptopArray);
                    return true;
                case 3: return false;
                default:
                    Console.WriteLine("Thank you");
                    return true;
            }
        }

        static Laptop[] DynamicArray(Laptop[] arr)
        {
            Laptop[] temp = new Laptop[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }
        static Laptop[] AddElements(Laptop[] arr)
        {
            Console.WriteLine("Enter element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Laptop();
                Console.WriteLine("laptop name");
                string s = Console.ReadLine();
                arr[i].SetLaptopName(s);
                Console.WriteLine("model id");
                int n = int.Parse(Console.ReadLine());
                arr[i].SetAmount(n);
                Console.WriteLine("Price");
                float k = float.Parse(Console.ReadLine());
                arr[i].SetAmount(k);
                Console.WriteLine("ram");
                byte b = byte.Parse(Console.ReadLine());
                arr[i].SetRam(b);




            }
            return arr;
        }
        static void Display(Laptop[] arr)
        {
            for (int i = arr.Length-1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetAmount());
                Console.WriteLine(arr[i].GetRam());
                Console.WriteLine(arr[i].GetModelNumber());
                Console.WriteLine(arr[i].GetLaptopName());
            }
        }


    }
}
