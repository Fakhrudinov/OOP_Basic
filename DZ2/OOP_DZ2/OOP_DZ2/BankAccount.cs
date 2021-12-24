namespace OOP_DZ2
{
    public class BankAccount
    {
        private static ulong accountNumber = 0;

        public static ulong AccountNumber 
        { 
            get => accountNumber; 
            set => accountNumber = value; 
        }

        public enum bankAccountType
        {
            DebetCard = 3,
            CreditCard = 5,
            Premial = 10
        }
    }
}
