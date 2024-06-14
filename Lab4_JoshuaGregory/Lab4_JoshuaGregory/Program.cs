// Joshua Gregory; June 2024
// SimpleBankAccount driver file
namespace Lab4_JoshuaGregory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a checking and savings object
            Checking c1 = new Checking();
            Savings s1 = new Savings();

            // driver with user menu
            string menu = "\nWelcome to your bank account menu." +
                          "\n----------------------------------" +
                          "\n1. Withdraw from checking account" +
                          "\n2. Withdraw from savings account" +
                          "\n3. Deposit to checking account" +
                          "\n4. Deposit to savings account" +
                          "\n5. View checking account balance" +
                          "\n6. View savings account balance" +
                          "\n7. Applysavings account interest" +
                          "\n8. Exit\n" +
                          "\nPlease enter a number from above:";

            do
            {
                Console.WriteLine(menu);
                string userInp = Console.ReadLine();

                if(userInp == "1")
                {
                    Console.WriteLine("Enter amount to withdraw from checking account.");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    c1.withdraw(withdrawAmount);
                }
                else if(userInp == "2")
                {
                    Console.WriteLine("Enter amount to withdraw from savings account.");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    s1.withdraw(withdrawAmount);
                }
                else if(userInp == "3")
                {
                    Console.WriteLine("Enter amount to deposit to checking account.");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    c1.deposit(depositAmount);
                }
                else if(userInp == "4")
                {
                    Console.WriteLine("Enter amount to deposit to savings account.");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    s1.deposit(depositAmount);
                }
                else if(userInp == "5")
                {
                    Console.WriteLine($"Checking account balance: ${c1.getAccountBalance()}");
                }
                else if(userInp == "6")
                {
                    Console.WriteLine($"Savings account balance: ${s1.getAccountBalance()}");
                }
                else if(userInp == "7")
                {
                    s1.applyInterest();
                }
                else if(userInp == "8")
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from the menu.");
                }

            } while (true);

        }
    }
}
