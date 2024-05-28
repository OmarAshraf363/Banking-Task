using System.Xml;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingAccount account = new SavingAccount();
            //Console.WriteLine(account);
            //account.WhithDraw(200);
            //Console.WriteLine(account.GetBalance());
            //Console.WriteLine("==============");
            //CheckingAccount account1 = new CheckingAccount("New");
            //Console.WriteLine(account1);
            //account1.WhithDraw(200);
            //Console.WriteLine(account1.GetBalance());

            //List<Account> account = new List<Account>()
            //{
            //    new SavingAccount(),
            //    new SavingAccount(),

            //};

            //AccountUtil.Deposite(account, 500);
            //AccountUtil.Desplay(account);
            //Console.WriteLine("=================");
            //AccountUtil.WithDraw(account, 200);
            //AccountUtil.Desplay(account);
            //Console.WriteLine("==================");
            //List<Account> accounts = new List<Account>()
            //{
            //    new CheckingAccount("Omar"),
            //    new CheckingAccount("Fahed")


            //};
            //AccountUtil.Deposite(accounts,500);
            //AccountUtil.Desplay(accounts);
            //Console.WriteLine("=================");
            //AccountUtil.WithDraw(accounts, 200);
            //AccountUtil.Desplay(accounts);
            //=====================================
            //TrustAccount account = new TrustAccount();
            //Console.WriteLine(account);
            //account.Deposite(500);
            //Console.WriteLine(account);
            //Console.WriteLine("===========");
            //account.WhithDraw(200);
            //account.WhithDraw(160);
            //account.WhithDraw(50);
            //account.WhithDraw(10);
            //account.WhithDraw(5);
            //account.WhithDraw(2);
            //Account account = new Account();
            //Account account1 = new Account();
            //Account account2=account1+account;
            //Console.WriteLine(account2.Name);

            List<Account> accounts = new List<Account>()
            {
                //Orginal Accounts
                new Account(),
                new Account("Omar") ,
                new Account("Fahed",2000),
                new Account("Mostafa",5000) ,
                
                //==========================
                // Saving Accounts
                new SavingAccount(),
                new SavingAccount("Ahmed"),
                new SavingAccount("Yasmen",2000),
                new SavingAccount("Mohamed",5000,0.5),
                //=========================
                //Checking Accounts
                new CheckingAccount(),
                new CheckingAccount("Ahmed"),
                new CheckingAccount("Yasmen",2000),
                new CheckingAccount("Mohamed",5000,0.5),
              //  ===============================================
              //Trust Accounts
                new TrustAccount(),
                new TrustAccount("Mahmoud"),
                new TrustAccount("saed",2000),
                new TrustAccount("Abdallah",5000,0.5),

            };
            //Methods From Sperat Class ==>Account Utility
            AccountUtil.Desplay(accounts);
            AccountUtil.Deposite(accounts,1000);
            AccountUtil.WithDraw(accounts,1000);
           









        }
    }
}
