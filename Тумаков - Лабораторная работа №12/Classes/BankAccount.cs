namespace Тумаков___Лабораторная_работа__12
{
    /// <summary>
    /// Перечислимый тип, содержащий виды банковских счетов.
    /// </summary>
    enum AccountType
    {
        Текущий_счет,
        Сберегательный_счет
    }

    /// <summary>
    /// Класс, описывающий счет в банке.
    /// </summary>
    class BankAccount
    {
        #region Поля
        private static int numberOfBankAccounts;
        private decimal accountBalance;
        readonly int accountNumber;     
        readonly AccountType bankAccountType;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле accountBalance.
        /// </summary>
        public decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }
        #endregion

        #region Переопределение операций сравнения
        /// <summary>
        /// Переопределение опреации ==.
        /// </summary>
        /// <param name="firstBankAccount"> Первый операнд, банковский счет. </param>
        /// <param name="secondBankAccount"> Второй операнд, банковский счет. </param>
        /// <returns> Возвращает true, если операнды равны, иначе false. </returns>
        public static bool operator ==(BankAccount firstBankAccount, BankAccount secondBankAccount)
        {
            return ((firstBankAccount.accountNumber == secondBankAccount.accountNumber) && (firstBankAccount.accountBalance == secondBankAccount.accountBalance) && (firstBankAccount.bankAccountType == secondBankAccount.bankAccountType));
        }

        /// <summary>
        /// Переопределение опреации !=.
        /// </summary>
        /// <param name="firstBankAccount"> Первый операнд, банковский счет. </param>
        /// <param name="secondBankAccount"> Второй операнд, банковский счет. </param>
        /// <returns> Возвращает true, если операнды неравны, иначе false. </returns>
        public static bool operator !=(BankAccount firstBankAccount, BankAccount secondBankAccount)
        {
            return ((firstBankAccount.accountNumber != secondBankAccount.accountNumber) || (firstBankAccount.accountBalance != secondBankAccount.accountBalance) || (firstBankAccount.bankAccountType != secondBankAccount.bankAccountType));
        }
        #endregion

        #region Переопределение методов
        /// <summary>
        /// Переопределение метода Equals.
        /// </summary>
        /// <param name="obj"> Банковский счет. </param>
        /// <returns> Возвращает true, если банковские счета равны, иначе false. </returns>
        public override bool Equals(object obj)
        {
            if (obj is BankAccount bankAccount)
            {
                if ((accountNumber == bankAccount.accountNumber) && (accountBalance == bankAccount.accountBalance) && (bankAccountType == bankAccount.bankAccountType))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Переопределение метода GetHashCode.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Переопределение метода ToString.
        /// </summary>
        /// <returns> Возвращает строку с данными о банковском счете. </returns>
        public override string ToString()
        {
            return $"{bankAccountType} №{accountNumber:D4} содержит {accountBalance} рублей";
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, изменяющий количество банковских счетов (поле numberOfBankAccounts).
        /// </summary>
        private void ChangeNumberOfBankAccounts()
        {
            numberOfBankAccounts++;
        }

        /// <summary>
        /// Метод, снимающий некоторую денежную сумму с банковского счета.
        /// </summary>
        /// <param name="withdrawalAmount"> Денежная сумма, которую необходимо снять. </param>
        /// <returns> Возвращает true, если снятие денежной суммы возможно, иначе false. </returns>
        public bool WithdrawMoneyFromAccount(decimal withdrawalAmount)
        {
            if ((accountBalance - withdrawalAmount > 0) && (withdrawalAmount > 0))
            {
                accountBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод, пополняющий банковский счет на некоторую денежную сумму.
        /// </summary>
        /// <param name="depositedAmoun"> Денежная сумма, которую необходимо внести. </param>
        /// <returns> Возвращает true, если пополнение возможно, иначе false. </returns>
        public bool PutMoneyIntoAccount(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accountBalance += depositedAmoun;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод, позволяющий переводить деньги с одного счета на другой.
        /// </summary>
        /// <param name="withdrawalAccount"> Счет, с которого снимаются деньги. </param>
        /// <param name="withdrawalAmount"> Сумма снятия. </param>
        /// <returns> Возвращает true, если перевод денег возможен, иначе false. </returns>
        public bool TransferringMoney(BankAccount withdrawalAccount, decimal withdrawalAmount)
        {
            if ((withdrawalAmount > 0) && (withdrawalAccount.AccountBalance - withdrawalAmount > 0))
            {
                accountBalance += withdrawalAmount;
                withdrawalAccount.accountBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccount и заполняет его данными.
        /// </summary>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        public BankAccount(decimal accountBalance)
        {
            this.accountBalance = accountBalance;
            bankAccountType = AccountType.Текущий_счет;
            accountNumber = numberOfBankAccounts;
            ChangeNumberOfBankAccounts();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccount и заполняет его данными.
        /// </summary>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        public BankAccount(AccountType bankAccountType)
        {
            this.bankAccountType = bankAccountType;
            accountBalance = 0;
            accountNumber = numberOfBankAccounts;
            ChangeNumberOfBankAccounts();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccount и заполняет его данными.
        /// </summary>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        public BankAccount(decimal accountBalance, AccountType bankAccountType)
        {
            this.accountBalance = accountBalance;
            this.bankAccountType = bankAccountType;
            accountNumber = numberOfBankAccounts;
            ChangeNumberOfBankAccounts();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccount и заполняет его данными.
        /// </summary>
        public BankAccount()
        {
            accountBalance = 0;
            bankAccountType = AccountType.Текущий_счет;
            accountNumber = numberOfBankAccounts;
            ChangeNumberOfBankAccounts();
        }
        #endregion
    }
}
