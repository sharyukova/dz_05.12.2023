using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov13.Classes
{
    internal class BankTransaction
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
        private uint withdrawalAmount;
        private uint depositedAmount;

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccountEx1 и заполняет его данными.
        /// </summary>
        /// <param name="numberOfAccount"> Номер банковского счета. </param>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        /// <param name="withdrawalAmount"> Сумма, которую собираетесь снять со счета. </param>
        /// <param name="bankAccountOwner"> Держатель банковского счета (владелец, имя владельца). </param>
        /// <param name="depositedAmount"> Сумма, которую собираетесь положить на счет. </param>
        public BankTransaction(uint accountNumber, uint accountBalance, AccountType bankAccountType, uint withdrawalAmount, uint depositedAmount)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.bankAccountType = bankAccountType;
            this.withdrawalAmount = withdrawalAmount;
            this.depositedAmount = depositedAmount;
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


        /// <summary>
        /// Свойство для снятия с банковского счета
        /// </summary>
        public uint WithdrawMoneyFromAccount
        {
            get
            {
                if (accountBalance - withdrawalAmount > 0)
                {
                    return accountBalance -= withdrawalAmount;
                }
                Console.WriteLine("Запрашиваемая сумма превышает баланс на счете. Снять невозможно.");
                return accountBalance;
            }
        }

        
        /// <summary>
        /// Свойство для того, чтобы положить на счет.
        /// </summary>
        public uint PutMoneyIntoAccount
        {
            get
            {
                return accountBalance += depositedAmount;
            }
        }

    }
}
