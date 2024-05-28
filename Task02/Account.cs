using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Account
    {

        public string Name { get; set; }
        public decimal Balance {  get; set; }
        public Account(string name="UnKnowen", decimal balance=500)
        {
            Name = name;
            Balance = balance;
        }
        public bool Deposite(decimal amount)
        {
            if(amount >0)
            {
                Balance += amount;
                return true;

            }
            else { return false; }
            
        }
        public bool WithDraw(decimal amount)
        {
           if(amount>Balance||amount<0)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public void print()
        {
            Console.WriteLine($"acc : {Name} , Balance : {Balance} ");
        }
    }
}
