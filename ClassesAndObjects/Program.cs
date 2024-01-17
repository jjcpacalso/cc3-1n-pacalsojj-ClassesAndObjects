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

            BankAccount ninaAccount = new BankAccount("Nina", 500);

            Console.WriteLine($"Account {ninaAccount.AccountNumber} was created for {ninaAccount.Owner} with {ninaAccount.Balance} initial balance.");
        }
        static void newMain()
        {
            Console.WriteLine("Test");
        }
    }
}
