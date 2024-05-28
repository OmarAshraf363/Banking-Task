using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class SavingAccount:Account
    {

        public double Rate {  get; set; }
        public SavingAccount(string name="Saving",double balance=500, double rate=0):base(name,balance)
        {
            Rate = rate;
        }
        public override string GetBalance()
        {
            return base.GetBalance();
        }

    }
}
