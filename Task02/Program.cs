namespace Task02
{
    internal class Program
    {
        static MenuOption ReadOption()
        {
            int c = 0;
            do
            {
                Console.WriteLine("1- WithDraw ");
                Console.WriteLine("2- Diposite ");
                Console.WriteLine("3- Print ");
                Console.WriteLine("4- Quite  ");
                Console.WriteLine("Enter your option : ");
                c =int.Parse(Console.ReadLine());

            } while( c<1||c>4 );
            return (MenuOption)c-1;
        }
        static void DoDeposite(Account account,decimal amount)
        {
            if (account.Deposite(amount))
            {
                Console.WriteLine("All Done...succes deposite in Account ");
                account.print();
            }
            else { Console.WriteLine("Faild Deposite"); }
            
        }
        static void DoWithDraw(Account account,decimal amount)
        {
            if (account.WithDraw(amount))
            {
                Console.WriteLine("All Done...succes WithDraw in Account");
                account.print();
            }
            else { Console.WriteLine("Faild WithDraw "); }
        }
        static void DoPrint(Account account)
        {
            account.print();
        }
     enum MenuOption
    {
            WithDraw,
            Depodite,
            Print,
            Quit


    }
        static void Main(string[] args)
        {
            Account account= new Account();
            switch(ReadOption())
            {
                case MenuOption.WithDraw:
                    DoWithDraw(account, 500);
                    break;
                case MenuOption.Depodite:
                    DoDeposite(account, 1000);
                    break;
                case MenuOption.Print:
                    DoPrint(account);
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Good Bye");
                    break;
                default:
                    Console.WriteLine("Error 404");
                    break;


            }
           
        }
    }
}
