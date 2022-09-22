using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface us = new UserInterface();

            us.ShowStart();
        }
    }
}