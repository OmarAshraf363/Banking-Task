using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class TrustAccount:SavingAccount
    {
        int counter = 0;
      

        public TrustAccount(string name = "Trust", double balance = 500, double rate = 0) : base(name, balance)
        {
            Rate = rate;
        }
        public  override bool Deposite(double Amount)
        {
            if (Amount < 0)
            {
                return false;
            }else if(Amount >= 5000)
            {
                double bouns = 50.00;
               base.Deposite(Amount);
                Balance += bouns;
                return true;
            }else
            {
                base.Deposite(Amount);
                return true;
            }
           
        }
        
        public override bool WhithDraw(double Amount)
        {

            if (counter < 3)
            {

                double temp = Balance * 20 / 100;

        

                 if (Amount <= temp)
                {

                    if (base.WhithDraw(Amount))
                    {
                       
                        counter++;
                        
                        Console.WriteLine($"WhithDraw {Amount} in acc: {Name} ");
                      
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                else
                {
                    Console.Write($"WithDraw must be less than 20% from your balance : {temp} ");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("only WhithDraw 3 times in year...");
                return false;
            }






        }
    }
}
