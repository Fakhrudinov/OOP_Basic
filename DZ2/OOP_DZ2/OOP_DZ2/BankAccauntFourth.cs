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

        internal void TransferMoneyToAccount(BankAccauntFourth accauntFrom, double moneyToTransfer)
        {
            bool successTransferFrom = false;
            bool successTransferTo = false;

            //check money avaliableness
            if (accauntFrom.BankAccountAmount >= moneyToTransfer)
            {
                successTransferFrom = ChangeMoneyAmount(accauntFrom, moneyToTransfer * -1);
                successTransferTo = ChangeMoneyAmount(this, moneyToTransfer);

                if (successTransferFrom && successTransferTo)
                {
                    Console.WriteLine("OK. Transfer operation complete");
                }
                else if (!successTransferFrom && !successTransferTo)
                {
                    Console.WriteLine($"Alert! Transfer failed completely!");
                }
                else if (!successTransferFrom)
                {
                    //error at donor
                    //try to return money at recipient
                    successTransferFrom = ChangeMoneyAmount(this, moneyToTransfer * -1);
                }
                else if (!successTransferTo)
                {
                    //error at recipient
                    //try to return money to donor
                    successTransferTo = ChangeMoneyAmount(accauntFrom, moneyToTransfer);
                }
            }
            else
            {
                Console.WriteLine($"Alert! Not enough money on accaunt number {accauntFrom.BankAccountNumber} to transfer amount {moneyToTransfer}");
            }
        }

        private bool ChangeMoneyAmount(BankAccauntFourth accaunt, double moneyToTransfer)
        {
            accaunt.BankAccountAmount = accaunt.BankAccountAmount + moneyToTransfer;
            // some logic to understand is transfer complete
            return true;
        }
    }
}
