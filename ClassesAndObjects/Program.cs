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

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overwithdraw.");
            }catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            BankAccount ninaAccount = new BankAccount("Nina", 500);

            Console.WriteLine($"Account {ninaAccount.AccountNumber} was created for {ninaAccount.Owner} with {ninaAccount.Balance} initial balance.");

            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("Invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance.");
                Console.WriteLine(e.Message);
                return;
            }
        }
        static void newMain()
        {
            Console.WriteLine("Test");
        }
    }
}
