﻿using System;
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
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(Transaction transaction in _allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }
        private List<Transaction> _allTransactions = new List<Transaction>();
        
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            AccountNumber = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            Transaction deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            Transaction withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }
        
        public string GetAccountHistory()
        {
            StringBuilder report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach(Transaction transaction in _allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}");
            }

            return report.ToString();
        }
        
    }
}
