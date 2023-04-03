using System;

namespace BankAccountExample
{
    public class BankAccount
    {
        public string AccountName { get; set; }
        public double Balance { get; set; }

        public static BankAccount operator ++(BankAccount account)
        {
            account.Balance += 1;
            return account;
        }

        public static bool operator >(BankAccount acc1, BankAccount acc2)
        {
            return acc1.Balance > acc2.Balance;
        }

        public static bool operator <(BankAccount acc1, BankAccount acc2)
        {
            return acc1.Balance < acc2.Balance;
        }

        public static BankAccount operator +(BankAccount acc1, BankAccount acc2)
        {
            return new BankAccount
            {
                AccountName = $"{acc1.AccountName} + {acc2.AccountName}",
                Balance = acc1.Balance + acc2.Balance
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new BankAccount { AccountName = "Checking", Balance = 1000 };
            BankAccount savingsAccount = new BankAccount { AccountName = "Savings", Balance = 5000 };

            //using ++
            checkingAccount++;
            Console.WriteLine($"Checking account balance after using ++: {checkingAccount.Balance}");

            //using > & <
            Console.WriteLine($"Is the checking account balance greater than the savings account balance? {checkingAccount > savingsAccount}");
            Console.WriteLine($"Is the checking account balance less than the savings account balance? {checkingAccount < savingsAccount}");

            //using +
            BankAccount combinedAccount = checkingAccount + savingsAccount;
            Console.WriteLine($"Combined account balance: {combinedAccount.Balance}");
        }
    }
}
