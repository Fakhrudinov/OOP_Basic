using System;

namespace OOP_DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс1");
            BankAccauntFirst bankAccauntFirst = new BankAccauntFirst();
            bankAccauntFirst.SetBankAccountType(BankAccount.bankAccountType.CreditCard);
            bankAccauntFirst.SetBankAccountAmount(99.99);
            bool setNumber = bankAccauntFirst.SetBankAccountNumber("0001 0002 0003 0321");

            Console.WriteLine($"New account is: '{bankAccauntFirst.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntFirst.GetBankAccountType()}', " +
                $"amount: {bankAccauntFirst.GetBankAccountAmount()}");


            Console.WriteLine("\nКласс2");
            BankAccauntSecond bankAccauntSecond = new BankAccauntSecond();
            bankAccauntSecond.SetBankAccountType(BankAccount.bankAccountType.Premial);
            bankAccauntSecond.SetBankAccountAmount(88.88);
            bankAccauntSecond.GenerateBankAccountNumber();

            Console.WriteLine($"New account is: '{bankAccauntSecond.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntSecond.GetBankAccountType()}', " +
                $"amount: {bankAccauntSecond.GetBankAccountAmount()}");


            Console.WriteLine("\nКласс3");
            BankAccauntThird bankAccauntThird0 = new BankAccauntThird();
            BankAccauntThird bankAccauntThird1 = new BankAccauntThird(55.55);
            BankAccauntThird bankAccauntThird2 = new BankAccauntThird(BankAccount.bankAccountType.CreditCard);
            BankAccauntThird bankAccauntThird3 = new BankAccauntThird(BankAccount.bankAccountType.Premial, 77.77);
            Console.WriteLine($"New account is: '{bankAccauntThird0.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntThird0.GetBankAccountType()}', " +
                $"amount: {bankAccauntThird0.GetBankAccountAmount()}");
            Console.WriteLine($"New account is: '{bankAccauntThird1.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntThird1.GetBankAccountType()}', " +
                $"amount: {bankAccauntThird1.GetBankAccountAmount()}");
            Console.WriteLine($"New account is: '{bankAccauntThird2.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntThird2.GetBankAccountType()}', " +
                $"amount: {bankAccauntThird2.GetBankAccountAmount()}");
            Console.WriteLine($"New account is: '{bankAccauntThird3.GetBankAccountNumber()}' " +
                $"with type '{bankAccauntThird3.GetBankAccountType()}', " +
                $"amount: {bankAccauntThird3.GetBankAccountAmount()}");


            Console.WriteLine("\nКласс4");
            BankAccauntFourth bankAccauntFourth = new BankAccauntFourth();
            bankAccauntFourth.BankAccountAmount = 22.22;
            bankAccauntFourth.BankAccountType = BankAccount.bankAccountType.Premial;

            BankAccauntFourth bankAccauntFourth1 = new BankAccauntFourth(BankAccount.bankAccountType.CreditCard);
            bankAccauntFourth1.BankAccountAmount = 11.11;

            Console.WriteLine($"New account is: '{bankAccauntFourth.BankAccountNumber}' " +
                $"with type '{bankAccauntFourth.BankAccountType}', " +
                $"amount: {bankAccauntFourth.BankAccountAmount}");

            Console.WriteLine($"New account is: '{bankAccauntFourth1.BankAccountNumber}' " +
                $"with type '{bankAccauntFourth1.BankAccountType}', " +
                $"amount: {bankAccauntFourth1.BankAccountAmount}");

            Console.ReadLine();
        }
    }
}
