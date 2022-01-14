using System;

namespace OOP_DZ2
{
    internal class BankAccauntFourth
    {
        /*
         * В классе все методы для заполнения и получения значений полей заменить на свойства.
         */

        private string _bankAccountNumber;
        private double _bankAccountAmount;
        private BankAccount.bankAccountType _bankAccountType;

        public double BankAccountAmount 
        {
            get { return _bankAccountAmount; }
            set { _bankAccountAmount = value; }
        }

        public BankAccount.bankAccountType BankAccountType
        {
            get { return _bankAccountType; }
            set { _bankAccountType = value; }
        }

        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            // роль сета выполняет GenerateBankAccountNumber()
        }

        // по заданию конструкторы вроде как не надо убирать, так что оставлю
        internal BankAccauntFourth()
        {
            GenerateBankAccountNumber();
            _bankAccountType = BankAccount.bankAccountType.DebetCard;
        }
        internal BankAccauntFourth(double bankAccountAmount) 
            : this(BankAccount.bankAccountType.DebetCard, bankAccountAmount)
        {
            BankAccountAmount = bankAccountAmount;
        }
        internal BankAccauntFourth(BankAccount.bankAccountType bankAccountType) 
            : this(bankAccountType, 0)
        {
            _bankAccountType = bankAccountType;
        }
        internal BankAccauntFourth(BankAccount.bankAccountType bankAccountType, double bankAccountAmount)
        {
            _bankAccountType = bankAccountType;
            BankAccountAmount = bankAccountAmount;
            GenerateBankAccountNumber();
        }

        //оставил доступным, т.к. если убирать конструкторы - то этим методом будем генерить номер
        internal void GenerateBankAccountNumber()
        {
            BankAccount.AccountNumber = BankAccount.AccountNumber += 1;

            _bankAccountNumber = String.Format("{0:0000 0000 0000 0000}", BankAccount.AccountNumber);
        }
    }
}
