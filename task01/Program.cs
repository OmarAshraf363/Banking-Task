namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Omar", 20000);
            Console.WriteLine(account.Print());
            account.Deposite(1000);
            account.WithDraw(15000);
            Console.WriteLine(account.Print());
            //Secound Account
            Account account1 = new Account("fahed",10000);
            Console.WriteLine(account1.Print());
            account1.Deposite(1000);
            account1.WithDraw(500);
            Console.WriteLine(account1.Print());

        }
    }
}
