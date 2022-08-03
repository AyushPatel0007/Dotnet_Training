using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventTask
{ 
    class Program
    { 
            static void message(string res)
            {
                Console.WriteLine("{0} You Are Banned From this Org.",res);
            }

            static void message1(string res)
            {
                Console.WriteLine("Welcome {0}",res);
            }
            static void Main(string[] args)
            {
                CheckBan a = new CheckBan();
                string res;
                Console.WriteLine("Enter the user name: ");
                res = Console.ReadLine();
                a.Banuser += new CheckBan.Chkban(message);
                a.Nonban += new CheckBan.Chkban(message1);
                a.Check(res);
                Console.Read();
            }
        }



        class CheckBan
        {
            public delegate void Chkban(string res);
            public event Chkban Banuser;
            public event Chkban Nonban;
            public void Check(string res)
            {
               
                if (((res.ToLower() == "ram") || (res.ToLower() == "shyam") || (res.ToLower() == "naveen")) &&(Banuser != null))
                {
                    Banuser(res);
                }
                else
                {
                    Nonban(res);
                }
            }

        }


    }
