using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov13.Classes
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

        // 13.2
        private BankTransaction[] transactions = new BankTransaction[10];
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < 10)
                {
                    return transactions[index];
                }
                else
                {
                    Console.WriteLine("Индекс вне массива");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < 10)
                {
                    transactions[index] = value;
                }
            }
        }
    }
}