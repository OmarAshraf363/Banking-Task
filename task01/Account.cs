using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Account
    {

        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
        public void Deposite(decimal amount)
        {
            Balance += amount;
        }
        public void WithDraw(decimal amount)
        {
            Balance -= amount;
        }
        public string Print()
        {
            return $"Acc Name : [ {Name} ]  , Acc Balance :[ {Balance} ]";
        }
    }
}
