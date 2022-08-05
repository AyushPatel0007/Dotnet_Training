using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bk = new List<BankAccount>();
            BankAccount bnk = new BankAccount();
            Console.WriteLine("Enter the Account Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            string Name = Console.ReadLine();
            bk.Add(new BankAccount( num, Name, 0 ));
            Step2:
            Console.WriteLine("Enter the Balance: ");
            double bal = double.Parse(Console.ReadLine());       
           
            int p=1;
            while (p != 0)
            {
                Console.WriteLine("Enter the Transaction Type(d/c): ");
                char c = Char.Parse(Console.ReadLine());



                bnk.Accountno = num;
                bnk.Name = Name;
                if (c == 'c')
                {
                    bk[0].Balance += bal;
                    Console.WriteLine("Available Balance: " + bk[0].Balance);
                }
                else
                {
                    if (bk[0].Balance > 500 && bk[0].Balance>bal)
                    {
                        bk[0].Balance -= bal;
                        Console.WriteLine("Available Balance: " + bk[0].Balance);

                    }
                    else
                    {
                        try
                        {
                            if (bk[0].Balance < 500 )
                                throw new CheckBalanceException();
 
                        }
                        catch (CheckBalanceException e)
                        {
                            e.Balance();

                        }
                    }
                
                }
            Console.Write("Enter 0 to exit");
            p = int.Parse(Console.ReadLine());
             if(p!=0)
             goto Step2;

            }


            Console.WriteLine("=============================================================================");
            Console.WriteLine("Name: "+bnk.Name+" \nAccount No: "+bnk.Accountno+" \nBalance is: " + bk[0].Balance);
             

        }
    }
}
