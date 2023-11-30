using System.Collections.Generic;

namespace Bank
{
    /// <summary>
    /// Статический класс, являющийся фабрикой объектов класса BankAccount.
    /// </summary>
    public static class BankAccountCreator
    {
        #region Поля
        private static Dictionary<int, BankAccount> accountsDictionary = new Dictionary<int, BankAccount>();
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле accountsDictionary.
        /// </summary>
        public static Dictionary<int, BankAccount> AccountsDictionary
        {
            get
            {
                return accountsDictionary;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий создать экземпляр класса BankAccount.
        /// </summary>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <returns> Возвращает номер номер банковского счета. </returns>
        public static int CreateAccount(decimal accountBalance)
        {
            BankAccount bankAccount = new BankAccount(accountBalance);
            accountsDictionary.Add(bankAccount.AccountNumber, bankAccount);
            return bankAccount.AccountNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса BankAccount.
        /// </summary>
        /// <param name="bankAccountType"> Вид банковского счета. </param>
        /// <returns> Возвращает номер номер банковского счета. </returns>
        public static int CreateAccount(AccountType bankAccountType)
        {
            BankAccount bankAccount = new BankAccount(bankAccountType);
            accountsDictionary.Add(bankAccount.AccountNumber, bankAccount);
            return bankAccount.AccountNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса BankAccount.
        /// </summary>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// /// <param name="bankAccountType"> Вид банковского счета. </param>
        /// <returns> Возвращает номер номер банковского счета. </returns>
        public static int CreateAccount(decimal accountBalance, AccountType bankAccountType)
        {
            BankAccount bankAccount = new BankAccount(accountBalance, bankAccountType);
            accountsDictionary.Add(bankAccount.AccountNumber, bankAccount);
            return bankAccount.AccountNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса BankAccount.
        /// </summary>
        /// <returns> Возвращает номер номер банковского счета. </returns>
        public static int CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();
            accountsDictionary.Add(bankAccount.AccountNumber, bankAccount);
            return bankAccount.AccountNumber;
        }

        /// <summary>
        /// Метод, позволяющий удалить банковский счет.
        /// </summary>
        /// <param name="accountNumber"> Номер банковского счета. </param>
        public static void ClosingBankAccount(int accountNumber)
        {
            accountsDictionary.Remove(accountNumber);
        }
        #endregion
    }
}
