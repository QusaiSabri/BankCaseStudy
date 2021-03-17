using System;
using BankCaseStudy.classes;

namespace BankCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Qusai", 1000);
            Console.WriteLine(" ");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            Console.WriteLine(" ");
        }
    }
}
