// Joshua Gregory; June 2024
// SimpleBankAccount Account parent class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_JoshuaGregory
{
    internal class Account
    {
        // parent attributes
        public static int accountTracker = 10000;
        public static int accountNumber;
        public double accountBalance;

        // parent constructors
        public Account()
        {           
            this.accountBalance = 0.0;
        }
        public Account(double newAccBal)
        {
            accountTracker++;
            accountNumber = accountTracker;
            this.accountBalance = newAccBal;
        }

        // get account number & get/set account balance
        public int getAccountNumber() { return accountNumber; }
        public double getAccountBalance() { return this.accountBalance; }
        public void setAccountBalance(double newAccBal) { this.accountBalance = newAccBal; }

        // deposit & withdraw methods
        public virtual void deposit(double depositAmount) 
        { 
            this.accountBalance += depositAmount;
            Console.WriteLine($"${depositAmount} has been deposited into account {accountNumber}.");
            Console.WriteLine($"New balance: ${this.accountBalance}.\n");
        }
        public virtual void withdraw(double withdrawAmount)
        {
            this.accountBalance -= withdrawAmount;
            Console.WriteLine($"${withdrawAmount} has been withdrawn from account {accountNumber}.");
            Console.WriteLine($"New balance: ${this.accountBalance}.\n");
        }
    }
}
