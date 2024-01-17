using System.Security.Principal;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BankAccount account = new BankAccount("Jerry", 1000);
            
            Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            BankAccount ninaAccount = new BankAccount("Nina", 500);

            Console.WriteLine($"Account {ninaAccount.AccountNumber} was created for {ninaAccount.Owner} with {ninaAccount.Balance} initial balance.");
        }
        static void newMain()
        {
            Console.WriteLine("Test");
        }
    }
}
