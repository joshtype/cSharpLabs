// Joshua Gregory; June 2024
// SimpleBankAccount Checking child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_JoshuaGregory
{
    internal class Checking : Account
    {
        // inherits accountNumber & accountBalance

        // constructor
        public Checking()
        {
            accountTracker++;
            accountNumber = accountTracker;
            this.accountBalance = 0.0;
        }
        public Checking(double newAccBal)
        {
            accountTracker++;
            accountNumber = accountTracker;
            this.accountBalance = newAccBal;
        }

        // inherits getAccountNumber(), getAccountBalance(), setAccountBalance(), deposit(), & withdraw()

        // modified withdraw() method
        public override void withdraw(double withdrawAmount)
        {
            this.accountBalance -= withdrawAmount;

            if (this.accountBalance < 0.0)
            {
                this.accountBalance -= 20.0;
                Console.WriteLine($"You have been charged $20 for overdrafting checking account {accountNumber} below $0.");
                Console.WriteLine($"New balance: ${this.accountBalance}.\n");
            }
            else
            {
                Console.WriteLine($"Withdrawal of ${withdrawAmount} from checking account {accountNumber} successful.");
                Console.WriteLine($"New balance: ${this.accountBalance}.\n");
            }
        }
    }
}
