using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Encapsulation
{
    internal class Accont
    {
        private double balance = 2000;
        public void SetBalance(double balance)
        {
            if (balance < 0)
                Console.WriteLine("please enter valid amount like more than 100 rs");
            else
                this.balance = this.balance + balance;
        }
        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
