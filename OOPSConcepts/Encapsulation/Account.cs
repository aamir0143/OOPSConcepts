using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.Encapsulation
{
    public class Account
    {
        public double balance = 2000;
        public void SetBalance(double balance)
        {
            if(balance < 0)
                Console.WriteLine("Please Enter the valid amount more than 100 rs ");
            else
                this.balance = this.balance + balance;
        }
        public void GetBalance()
        {
            Console.WriteLine("Current Balance is : " + balance);
        }
    }
}
