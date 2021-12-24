namespace OOP_DZ2
{
    internal class BankAccauntFirst
    {
        /*
         * Создать класс счет в банке с закрытыми полями: 
         * номер счета, 
         * баланс, 
         * тип банковского счета (использовать перечислимый тип). 
         * 
         * Предусмотреть методы для доступа к данным – заполнения и чтения. 
         * Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать
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
        internal bool SetBankAccountNumber(string number)
        {
            if (number.Length > 0)
            {
                _bankAccountNumber = number;
                return true;
            }
            else
            {
                return false;
            }            
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
