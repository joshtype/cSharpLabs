// Joshua Gregory; June 2024
// SimpleBankAccount Savings child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_JoshuaGregory
{
    internal class Savings : Account
    {
        // inherits accountNumber & accountBalance from parent
        private int depositTracker;

        // constructor
        public Savings()
        {
            accountTracker++;
            accountNumber = accountTracker;
            this.accountBalance = 0.0;
            this.depositTracker = 0;
        }
        public Savings(double newAccBal)
        {
            accountTracker++;
            accountNumber = accountTracker;
            this.accountBalance = newAccBal;
            this.depositTracker = 0;
        }

        // inherits getAccountNumber(), getAccountBalance(), setAccountBalance(), deposit(), & withdraw()

        // modified withdraw() method
        public override void withdraw(double withdrawAmount)
        {
            this.accountBalance -= withdrawAmount;

            if (this.accountBalance < 500.0)
            {
                this.accountBalance -= 10.0;
                Console.WriteLine($"Charging $10 fee to savings account number {accountNumber} because the balance is below $500.00.");
                Console.WriteLine($"New balance: ${this.accountBalance}.\n");
            }
            else
            {
                Console.WriteLine($"Withdrawal of ${withdrawAmount} from savings account {accountNumber} successful.");
                Console.WriteLine($"New balance: ${this.accountBalance}.\n");
            }
        }

        // modified deposit() method
        public override void deposit(double depositAmount)
        {
            this.accountBalance += depositAmount;
            this.depositTracker++;

            if (this.depositTracker > 5)
            {
                this.accountBalance -= 10.0;
                Console.WriteLine($"You have made {this.depositTracker} deposits into savings account number {accountNumber}, exceeding 5 free deposits by {this.depositTracker - 5}.");
                Console.WriteLine($"A $10 fee has been charged to your account. New balance: ${this.accountBalance}.\n");
            }
            else
            {
                Console.WriteLine($"You have made {this.depositTracker} deposits into savings account number {accountNumber}.");
                Console.WriteLine($"You have {5-this.depositTracker} free deposits remaining. New Balance: ${this.accountBalance}.\n");
            }
        }

        // apply 1.5% interest to savings balance
        public void applyInterest()
        {
            double interest = this.accountBalance * 0.015;
            this.accountBalance += interest;
            Console.WriteLine($"Savings account number {accountNumber} has earned ${interest} in annual interest.");
            Console.WriteLine($"New balance: ${this.accountBalance}.\n");
        }
    }
}
