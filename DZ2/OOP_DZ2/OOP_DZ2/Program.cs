using System;

namespace OOP_DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Класс1");
            //BankAccauntFirst bankAccauntFirst = new BankAccauntFirst();
            //bankAccauntFirst.SetBankAccountType(BankAccount.bankAccountType.CreditCard);
            //bankAccauntFirst.SetBankAccountAmount(99.99);
            //bool setNumber = bankAccauntFirst.SetBankAccountNumber("0001 0002 0003 0321");

            //Console.WriteLine($"New account is: '{bankAccauntFirst.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntFirst.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntFirst.GetBankAccountAmount()}");


            //Console.WriteLine("\nКласс2");
            //BankAccauntSecond bankAccauntSecond = new BankAccauntSecond();
            //bankAccauntSecond.SetBankAccountType(BankAccount.bankAccountType.Premial);
            //bankAccauntSecond.SetBankAccountAmount(88.88);
            //bankAccauntSecond.GenerateBankAccountNumber();

            //Console.WriteLine($"New account is: '{bankAccauntSecond.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntSecond.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntSecond.GetBankAccountAmount()}");


            //Console.WriteLine("\nКласс3");
            //BankAccauntThird bankAccauntThird0 = new BankAccauntThird();
            //BankAccauntThird bankAccauntThird1 = new BankAccauntThird(55.55);
            //BankAccauntThird bankAccauntThird2 = new BankAccauntThird(BankAccount.bankAccountType.CreditCard);
            //BankAccauntThird bankAccauntThird3 = new BankAccauntThird(BankAccount.bankAccountType.Premial, 77.77);
            //Console.WriteLine($"New account is: '{bankAccauntThird0.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntThird0.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntThird0.GetBankAccountAmount()}");
            //Console.WriteLine($"New account is: '{bankAccauntThird1.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntThird1.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntThird1.GetBankAccountAmount()}");
            //Console.WriteLine($"New account is: '{bankAccauntThird2.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntThird2.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntThird2.GetBankAccountAmount()}");
            //Console.WriteLine($"New account is: '{bankAccauntThird3.GetBankAccountNumber()}' " +
            //    $"with type '{bankAccauntThird3.GetBankAccountType()}', " +
            //    $"amount: {bankAccauntThird3.GetBankAccountAmount()}");


            Console.WriteLine("\nКласс4");
            BankAccauntFourth bankAccauntFourth = new BankAccauntFourth();
            bankAccauntFourth.BankAccountAmount = 22.22;
            bankAccauntFourth.BankAccountType = BankAccount.bankAccountType.Premial;

            BankAccauntFourth bankAccauntFourth1 = new BankAccauntFourth(BankAccount.bankAccountType.Premial);
            bankAccauntFourth1.BankAccountAmount = 33.11;
            /*
            Console.WriteLine($"New account is: '{bankAccauntFourth.BankAccountNumber}' " +
                $"with type '{bankAccauntFourth.BankAccountType}', " +
                $"amount: {bankAccauntFourth.BankAccountAmount}");

            Console.WriteLine($"New account is: '{bankAccauntFourth1.BankAccountNumber}' " +
                $"with type '{bankAccauntFourth1.BankAccountType}', " +
                $"amount: {bankAccauntFourth1.BankAccountAmount}");


            Console.WriteLine("\nКласс4, before transfer");
            BankAccauntFourth bankAccauntFifthDonor = new BankAccauntFourth(100);
            BankAccauntFourth bankAccauntFifthRecepient = new BankAccauntFourth(100);

            Console.WriteLine($"Account donor before transfer: '{bankAccauntFifthDonor.BankAccountNumber}' " +
                $"amount: {bankAccauntFifthDonor.BankAccountAmount}");

            Console.WriteLine($"Account recepient before transfer: '{bankAccauntFifthRecepient.BankAccountNumber}' " +
                $"amount: {bankAccauntFifthRecepient.BankAccountAmount}");
            Console.WriteLine("Класс4, transfer 50:");
            bankAccauntFifthRecepient.TransferMoneyToAccount(bankAccauntFifthDonor, 50);

            Console.WriteLine($"Account donor after transfer: '{bankAccauntFifthDonor.BankAccountNumber}' " +               
                $"amount: {bankAccauntFifthDonor.BankAccountAmount}");

            Console.WriteLine($"Account recepient after transfer: '{bankAccauntFifthRecepient.BankAccountNumber}' " +
                $"amount: {bankAccauntFifthRecepient.BankAccountAmount}");
            */




            /*
             * Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
             * Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
             * Переопределить методToString() для печати информации о счете. 
             * Протестировать функционирование переопределенных методов и операторов на простом примере.
             */
            Console.WriteLine("\nДомашнее задание 6: Переопределение операторов для счета\n");            
            BankAccauntFourth bankAccauntClient1 = new BankAccauntFourth(BankAccount.bankAccountType.CreditCard);
            bankAccauntClient1.BankAccountAmount = 11.11;
            BankAccauntFourth bankAccauntClient2 = new BankAccauntFourth(BankAccount.bankAccountType.DebetCard);
            bankAccauntClient2.BankAccountAmount = 11.11;
            BankAccauntFourth bankAccauntClient3 = new BankAccauntFourth(BankAccount.bankAccountType.CreditCard);// == bankAccauntClient1
            bankAccauntClient3.BankAccountAmount = 11.11;
            BankAccauntFourth bankAccauntClient4 = new BankAccauntFourth(BankAccount.bankAccountType.CreditCard);
            bankAccauntClient4.BankAccountAmount = 11.12;

            Console.WriteLine(bankAccauntClient1);
            Console.WriteLine(bankAccauntClient2);
            Console.WriteLine(bankAccauntClient3);
            Console.WriteLine(bankAccauntClient4);
            Console.WriteLine(bankAccauntFourth1);
            Console.WriteLine("\nCompare == and !==");
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} == {bankAccauntClient2.BankAccountNumber} " + (bankAccauntClient1 == bankAccauntClient2));//false по bankAccountType
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} == {bankAccauntClient3.BankAccountNumber} " + (bankAccauntClient1 == bankAccauntClient3));//true
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} == {bankAccauntClient4.BankAccountNumber} " + (bankAccauntClient1 == bankAccauntClient4));//false по деньгам
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} != {bankAccauntClient2.BankAccountNumber} " + (bankAccauntClient1 != bankAccauntClient2));//true
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} != {bankAccauntClient3.BankAccountNumber} " + (bankAccauntClient1 != bankAccauntClient3));//false
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} != {bankAccauntClient4.BankAccountNumber} " + (bankAccauntClient1 != bankAccauntClient4));//true
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber} != {bankAccauntFourth1.BankAccountNumber} " + (bankAccauntClient1 != bankAccauntFourth1));//true
            Console.WriteLine("\nEquals");
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber}.Equals({bankAccauntClient2.BankAccountNumber}) " + bankAccauntClient1.Equals(bankAccauntClient2));
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber}.Equals({bankAccauntClient3.BankAccountNumber}) " + bankAccauntClient1.Equals(bankAccauntClient3));
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber}.Equals({bankAccauntClient4.BankAccountNumber}) " + bankAccauntClient1.Equals(bankAccauntClient4));
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber}.Equals({bankAccauntFourth1.BankAccountNumber}) " + bankAccauntClient1.Equals(bankAccauntFourth1));
            Console.WriteLine("\nHash Code");
            Console.WriteLine($"{bankAccauntClient1.BankAccountNumber}.GetHashCode() " + bankAccauntClient1.GetHashCode());
            Console.WriteLine($"{bankAccauntClient2.BankAccountNumber}.GetHashCode() " + bankAccauntClient2.GetHashCode());
            Console.WriteLine($"{bankAccauntClient3.BankAccountNumber}.GetHashCode() " + bankAccauntClient3.GetHashCode());
            Console.WriteLine($"{bankAccauntClient4.BankAccountNumber}.GetHashCode() " + bankAccauntClient4.GetHashCode());
            Console.WriteLine($"{bankAccauntFourth1.BankAccountNumber}.GetHashCode() " + bankAccauntFourth1.GetHashCode());
            /*
             * Реализовать метод, который в качестве входного параметра принимает строку string, 
             * возвращает строку типа string, буквы в которой идут в обратном порядке. 
             * Протестировать метод.
             */

            //    string source = "abcdefgh1234567890";
            //    Console.WriteLine("turn order backward for letters in " + source);
            //    string result1 = GetStringInBackwardDirection1(source);
            //    Console.WriteLine(result1);

            //    string result2 = GetStringInBackwardDirection2(source);
            //    Console.WriteLine(result2);

            //    Console.ReadLine();
            //}

            //private static string GetStringInBackwardDirection1(string source)
            //{
            //    string result = "";

            //    for (int i = source.Length - 1; i >= 0; i--)
            //    {
            //        result = result + source[i];
            //    }

            //    return result;
            //}

            //private static string GetStringInBackwardDirection2(string source)
            //{
            //    char[] result = source.ToCharArray();

            //    //это слишком скучно
            //    //Array.Reverse(result);

            //    for (int i = 0; i < source.Length / 2; i++)
            //    {
            //        char frontLetter = source[i];
            //        result[i] = source[source.Length - (i + 1)];
            //        result[source.Length - (i + 1)] = frontLetter;
            //    }

            //    return new string(result);
        }
        }
    }
