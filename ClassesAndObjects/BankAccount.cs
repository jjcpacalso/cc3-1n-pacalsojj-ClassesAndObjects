using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class BankAccount
    {
        private static int s_accountNumberSeed = 1234567890;

        public string AccountNumber { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;
            AccountNumber = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            //TODO
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            //TODO
        }
    }
}
