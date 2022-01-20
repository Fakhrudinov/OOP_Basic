using System;

namespace OOP_DZ2
{
    internal class BankAccauntSecond
    {
        /*
         * Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
         * Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
         */

        private string _bankAccountNumber;
        private double _bankAccountAmount;
        private BankAccount.bankAccountType _bankAccountType;

        internal BankAccount.bankAccountType GetBankAccountType()
        {
            return _bankAccountType;
        }
        internal void SetBankAccountType(BankAccount.bankAccountType type)
        {
            _bankAccountType = type;
        }

        internal string GetBankAccountNumber()
        {
            return _bankAccountNumber;
        }
        internal void GenerateBankAccountNumber()
        {
            BankAccount.AccountNumber = BankAccount.AccountNumber += 1;

            _bankAccountNumber = String.Format("{0:0000 0000 0000 0000}", BankAccount.AccountNumber);
        }

        internal double GetBankAccountAmount()
        {
            return _bankAccountAmount;
        }
        internal void SetBankAccountAmount(double amount)
        {
            _bankAccountAmount = amount;
        }
    }
}
