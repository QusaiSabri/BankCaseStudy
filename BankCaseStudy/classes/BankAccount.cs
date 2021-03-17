using System;

namespace BankCaseStudy.classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }
        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
        }
    }
}