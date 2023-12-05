using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov14
{
    internal class BankAccount
    {
        /// <summary>
        /// Перечислимый тип, содержащий виды банковских счетов.
        /// </summary>
        public enum AccountType
        {
            Текущий,
            Сберегательный
        }

        private uint accountNumber;
        private uint accountBalance;
        private AccountType bankAccountType;
        private string bankAccountOwner;

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccount и заполняет его данными.
        /// </summary>
        /// <param name="numberOfAccount"> Номер банковского счета. </param>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        /// <param name="bankAccountOwner"> Держатель банковского счета (владелец, имя владельца). </param>
        public BankAccount(uint accountNumber, uint accountBalance, AccountType bankAccountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.bankAccountType = bankAccountType;
        }

        /// <summary>
        /// Свойство, возвращающее значение номера аккаунта.
        /// </summary>
        public uint AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        /// <summary>
        /// Свойство, возвращающее значение баланса.
        /// </summary>
        public uint AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }

        /// <summary>
        /// Свойство, возвращающее тип банковского аккаунта. Сберегательный .. Текущий
        /// </summary>
        public AccountType BankAccountType
        {
            get
            {
                return bankAccountType;
            }
        }

        /// <summary>
        /// Свойство, принимающее и возвращающее держателя банковского счета.
        /// </summary>
        public string AccountOwner
        {
            get
            {
                return bankAccountOwner;
            }
            set
            {
                bankAccountOwner = value;
            }
        }
        
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + bankAccountOwner);
            Console.WriteLine("Balance: " + accountBalance);
        }
    }
}
