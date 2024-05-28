using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal static class AccountUtil
    {
        public static void Desplay(List<Account> accounts)
        {
            foreach(var account in accounts)
            {
                Console.WriteLine(account);
            }
            Console.WriteLine("================================");
        }
        public static void Deposite(List<Account> accounts,double amount)
        {
            foreach(var account in accounts)
            {
                if (account.Deposite(amount))
                {
                    Console.WriteLine($"Deposited {amount} in acc: {account.Name}");
                    
                    Console.WriteLine(account.ToString());

                }
                else
                {
                    Console.WriteLine("Faild Deposited");
                }
            }
            Console.WriteLine("================================");

        }
        public static void WithDraw(List<Account> accounts,double amount) 
        {
            foreach(var account in accounts)
            {
                if (account.WhithDraw(amount))
                {
                    //Console.Write($"WhithDraw {amount} in acc: {account.Name} ");

                    Console.WriteLine("Succesfull WithDraw...");
                    Console.WriteLine(account.ToString());
                }
                else
                {

                    Console.WriteLine("...Faild WithDraw");
                }
            }
            Console.WriteLine("================================");
        }
    }
}
