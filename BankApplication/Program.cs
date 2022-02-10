using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create array of accounts
            Account[] accounts = new Account[4];

            // initialize array with Accounts
            accounts[0] = new savingsAccount(25M, .03M);
            accounts[1] = new checkingAccount(80M, 1M);
            accounts[2] = new savingsAccount(200M, .015M);
            accounts[3] = new checkingAccount(400M, .5M);

            // loop through array, prompting user for debit and credit amounts
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"Account {i + 1} balance: {accounts[i].retriveBalance():C}");

                Console.Write($"\nEnter an amount to withdraw from Account {i + 1}: ");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

                accounts[i].debit(withdrawalAmount); // attempt to debit

                Console.Write($"\nEnter an amount to deposit into Account {i + 1}: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());

                // credit amount to Account
                accounts[i].credit(depositAmount);

                // if Account is a SavingsAccount, calculate and add interest
                if (accounts[i] is savingsAccount)
                {
                    // downcast
                    savingsAccount currentAccount = (savingsAccount)accounts[i];

                    decimal interestEarned = currentAccount.calculateInterest();
                    Console.WriteLine($"Adding {interestEarned:C} interest to Account {i + 1} (a SavingsAccount)");
                    currentAccount.credit(interestEarned);
                }

                Console.WriteLine($"\nUpdated Account {i + 1} balance: {accounts[i].retriveBalance():C}\n\n");
            }
        }
    }
}
