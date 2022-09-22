using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankAccount
{
    internal class UserInterface
    {
        public void ShowStart()
        {
            BankAccount ba = new();
            do
            {
                WriteLine("What would you like to do?" +
                   "\n1. See Balance" +
                   "\n2. Withdraw" +
                   "\n3. Deposit\n");

                int answer = Convert.ToInt16(ReadLine());
                Clear();
                switch (answer)
                {
                    case 1:
                        ba.PrintBalance();
                        break;
                    case 2:
                        Withdraw(ba);
                        break;
                    case 3:
                        Deposit(ba);
                        break;
                }
            } while (true);
        }

        public void Withdraw(BankAccount bankAccount)
        {
            Write("Withdraw amount: ");
            decimal amount = Convert.ToDecimal(ReadLine());
            Clear();
            bankAccount.Withdraw(amount);
            ReadKey();
            Clear();
        }

        public void Deposit(BankAccount bankAccount)
        {
            Write("Deposit amount: ");
            decimal amount = Convert.ToDecimal(ReadLine());
            Clear();
            bankAccount.Deposit(amount);
            ReadKey();
            Clear();
        }
    }
}
