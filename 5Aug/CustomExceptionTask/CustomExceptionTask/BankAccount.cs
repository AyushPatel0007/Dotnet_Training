using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class BankAccount
    {
        public int Accountno { get; set; }
       public  string Name { get; set; }
        public Double Balance { get; set; }
        
       public BankAccount()
        {

        }
        public BankAccount(int A,string N,Double B)
        {
            this.Accountno = A;
            this.Name = N;
            this.Balance = B;

        }
     }
}
