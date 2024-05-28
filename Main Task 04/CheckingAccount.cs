using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class CheckingAccount:Account
    {

        public double Fee {  get; set; }
        public CheckingAccount(string name="check",double balance=500,double fee=1.50):base(name,balance)
        {
            Fee = fee;
        }
        public override bool WhithDraw(double amount)
        {

            if (base.WhithDraw(amount))
            {
                Balance = Balance - Fee;
                return true;
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return $"Account :{Name} , Balance : {Balance}";
        }
    }
}
