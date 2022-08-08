using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionExcersice
{
    class Program
    {
       static Chair[] ch = new Chair[0];
        static Cot[] co = new Cot[0];
        static void Main(string[] args)
        {
             
            Boolean f = true;
            do
            {
                Console.WriteLine("Enter choice 1 Chair 2 for Cot");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Enter choice\n 1 Add \n 2 for Display\n 3 Exit");
                    int k = int.Parse(Console.ReadLine());
                    f = ChCategory(k);
                }
                else if(n==2)
                {
                    Console.WriteLine("Enter choice\n 1 Add \n 2 for Display\n 3 Exit");
                    int k = int.Parse(Console.ReadLine());
                    f = CoCategory(k);
                }
                else
                {
                    Console.WriteLine("Enter valid number ");
                }
                
            } while (f);
        }
        static Boolean CoCategory(int Choice)
        {
            switch (Choice)
            {
                case 1:
                    ch = DynamicArray(ch);
                    ch = AddElements(ch);
                    return true;

                case 2:
                    Display(ch);
                    return true;
                case 3:

                    return false;
                default:
                    Console.WriteLine("Thank you");
                    return true;
            }
        }
        static Boolean ChCategory(int Choice)
        {
            try
            {
                if(Choice > 3)
                throw new Myexception();
            }catch(Myexception ex)
            {
                ex.Valid();
            }
            switch (Choice)
            {
                case 1:
                    co = DynamicArrayy(co);
                    co = AddElementss(co);
                    return true;
                                
                case 2:
                    Display(co);
                    return true;
                case 3:

                    return false;
                default:
                    Console.WriteLine("Thank you");
                    return true;
            }
        }


        static Cot[] AddElementss(Cot[] arr)
        {
            Console.WriteLine("Enter element");
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {
                arr[i] = new Cot();

                try { 
                arr[i].Sftype("Chot");
                Console.WriteLine("Orderid: ");
                int na = int.Parse(Console.ReadLine());
                arr[i].Sorderid(na);



                Console.WriteLine("Qty: ");
                int n = int.Parse(Console.ReadLine());
                arr[i].Sqty(n);
                    ftpe:
                Console.WriteLine("furniture type: ");
                string name = Console.ReadLine();
                arr[i].Schtype(name);
                    try
                    {
                        if (name.ToLower() != "wood" && name.ToLower()!="steel")
                        {
                            throw new Myexception();
                        }

                    }
                    catch (Myexception e)
                    {
                        e.Notavailable();
                        goto ftpe;
                    }

                Console.WriteLine("Payment mode: ");
                string namea = Console.ReadLine();
                arr[i].Spay(namea);

                Console.WriteLine("Amount: ");
                int k = int.Parse(Console.ReadLine());
                arr[i].Samount(k);
                Console.WriteLine("rate: ");
                int b = int.Parse(Console.ReadLine());
                arr[i].Srate(b);

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }

            }
            return arr;
        }


        static Chair[] AddElements(Chair[] arr)
        {
            Console.WriteLine("Enter element");
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {   
                arr[i] = new Chair();
                arr[i].Sftype("Chair");
                Console.WriteLine("Orderid: ");
                int na = int.Parse(Console.ReadLine());
                arr[i].Sorderid(na);


                Console.WriteLine("Qty: ");
                int n = int.Parse(Console.ReadLine());
                arr[i].Sqty(n);
                ftpe:
                Console.WriteLine("Furniture type: ");
                string name = Console.ReadLine();
                arr[i].Schtype(name);
                try
                {
                    if (name.ToLower() != "wood" && name.ToLower() != "steel")
                    {
                        throw new Myexception();
                    }

                }
                catch (Myexception e)
                {
                    e.Notavailable();
                    goto ftpe;
                }

                Console.WriteLine("Payment mode: ");
                string namea = Console.ReadLine();
                arr[i].Spay(namea);

                Console.WriteLine("Amount: ");
                int k = int.Parse(Console.ReadLine());
                arr[i].Samount(k);
                Console.WriteLine("rate: ");
                int b = int.Parse(Console.ReadLine());
                arr[i].Srate(b);
            }
            return arr;
        }
        static Chair[] DynamicArray(Chair[] arr)
        {
            Chair[] temp = new Chair[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }
        static Cot[] DynamicArrayy(Cot[] arr)
        {
            Cot[] temp = new Cot[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        static void Display(Cot[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Id: " + arr[i].Gorderid());
                Console.WriteLine("Furniture type: " + arr[i].Gftype());
                Console.WriteLine("Capacity :" + arr[i].Gchcapacity());
                Console.WriteLine("Type :" + arr[i].Gchtype());
                Console.WriteLine("Qty is :" + arr[i].Gqty());

                Console.WriteLine("Amount is: " + arr[i].Gamount());
                Console.WriteLine("Amount type is: " + arr[i].Gpay());

                Console.WriteLine("Rate is :" + arr[i].Grate());


            }
        }


        static void Display(Chair[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Id: "+arr[i].Gorderid());
                Console.WriteLine("Furniture type: "+arr[i].Gftype());
                Console.WriteLine("Capacity :" + arr[i].Gchcapacity());
                Console.WriteLine("Type :" + arr[i].Gchtype());
                Console.WriteLine("Qty is :" + arr[i].Gqty());

                Console.WriteLine("Amount is: " + arr[i].Gamount());
                Console.WriteLine("Amount type is: " + arr[i].Gpay());

                Console.WriteLine("Rate is :" + arr[i].Grate());


            }
        }

    }
}
