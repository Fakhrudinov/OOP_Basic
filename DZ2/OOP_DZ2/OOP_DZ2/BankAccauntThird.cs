using System;

namespace OOP_DZ2
{
    internal class BankAccauntThird
    {
        /*
         * В классе банковский счет, удалить методы заполнения полей. 
         * Вместо этих методов создать конструкторы.
         * Переопределить конструктор по умолчанию, 
         * создать конструктор для заполнения поля баланс, 
         * конструктор для заполнения поля тип банковского счета, 
         * конструктор для заполнения баланса и типа банковского счета. 
         * Каждый конструктор должен вызывать метод, генерирующий номер счета.
         */

        private string _bankAccountNumber;
        private double _bankAccountAmount;
        private BankAccount.bankAccountType _bankAccountType;

        internal BankAccauntThird()
        {
            GenerateBankAccountNumber();
            _bankAccountType = BankAccount.bankAccountType.DebetCard;
        }

        internal BankAccauntThird(double bankAccountAmount) : this (BankAccount.bankAccountType.DebetCard, bankAccountAmount)
        { 
            _bankAccountAmount = bankAccountAmount;
        }
        internal BankAccauntThird(BankAccount.bankAccountType bankAccountType) : this (bankAccountType, 0)
        {
            _bankAccountType = bankAccountType;
        }
        internal BankAccauntThird(BankAccount.bankAccountType bankAccountType, double bankAccountAmount)
        {
            _bankAccountType = bankAccountType;
            _bankAccountAmount=bankAccountAmount;
            GenerateBankAccountNumber();
        }


        internal void GenerateBankAccountNumber()
        {
            BankAccount.AccountNumber = BankAccount.AccountNumber += 1;

            _bankAccountNumber = String.Format("{0:0000 0000 0000 0000}", BankAccount.AccountNumber);
        }

        internal string GetBankAccountNumber()
        {
            return _bankAccountNumber;
        }
        internal BankAccount.bankAccountType GetBankAccountType()
        {
            return _bankAccountType;
        }
        internal double GetBankAccountAmount()
        {
            return _bankAccountAmount;
        }
    }
}
