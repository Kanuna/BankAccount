using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankAccount
{
    internal class BankAccount
    {
        private decimal Balance { get; set; } = 100;

        public void PrintBalance()
        {
            WriteLine($"Balance: {Balance.ToString("c")}");
            ReadKey();
            Clear();
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                WriteLine($"You don't have enoug money to withdraw {withdrawAmount}$" +
                    $"\nYour balance: {Balance.ToString("c")}");
            }
            else
            {
                Balance -= withdrawAmount;
                WriteLine($"Withdraw successful." +
                    $"\nYou withdrew: {withdrawAmount.ToString("c")}" +
                    $"\nYour balance: {Balance.ToString("c")}");
            }
        }

        public void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
            WriteLine($"Deposit successful" +
                $"\nYour deposit: {depositAmount.ToString("c")}" +
                $"\nYour balance: {Balance.ToString("c")}");
        }
    }
}