using System;

namespace BankCaseStudy.classes
{
  public class BankAccount
  {
    public string Number { get; set; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }
    public void MakeWithdrawl(decimal amount, DateTime date, string note)
    {
    }
  }
}