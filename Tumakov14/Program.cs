using System;

namespace Tumakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(123345, 12300, BankAccount.AccountType.Текущий);

            account.DumpToScreen();
        }
    }
}
