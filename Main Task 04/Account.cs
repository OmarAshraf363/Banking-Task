using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Account
    {

        public string Name {  get; set; }
        public double Balance { get; set; }
        public Account(string name="unKnowen", double balance=500)
        {
            Name = name;
            Balance = balance;
        }
        public virtual bool Deposite(double amount)
        {
            if (amount<0)
            {
                return false;
            }
            else
            {
                Balance+=amount;
                return true;

            }
        }
        public virtual bool WhithDraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }

        }
        public virtual string GetBalance()
        {
            return $"Balance : {Balance}";
        }
        public override string ToString()
        {
            return $"Account :{Name} , Balance : {Balance}";
        }
        public static Account operator+(Account a, Account b)
        {
           Account account= new Account();
            account.Balance= a.Balance+b.Balance;
            return account ;
        }

    }
}
