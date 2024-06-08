// Joshua Gregory; June 2024
// Money Dispenser Driver File
using System.Reflection.Metadata.Ecma335;

namespace Assignment1_JoshuaGregory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1: CREATE NOTES & COINS OBJECTS, DISPLAY TOTAL VALUE & WEIGHT
            Notes twenties = new Notes(20);
            Notes tens = new Notes(10);
            Notes fives = new Notes(5);
            Notes ones = new Notes(1);
            Coins quarters = new Coins(0.25f, 0.2f);
            Coins dimes = new Coins(0.10f, 0.08f);
            Coins nickels = new Coins(0.05f, 0.176f);
            Coins pennies = new Coins(0.01f, 0.088f);

            // set quantityOnHand values
            pennies.increaseQuantity(132);
            nickels.increaseQuantity(17);
            dimes.increaseQuantity(41);
            ones.increaseQuantity(33);
            fives.increaseQuantity(12);
            tens.increaseQuantity(2);
            twenties.increaseQuantity(5);

            // display total value of each coin/note obj
            Console.WriteLine(pennies.ToString());
            Console.WriteLine(nickels.ToString());
            Console.WriteLine(dimes.ToString());
            Console.WriteLine(ones.ToString());
            Console.WriteLine(fives.ToString());
            Console.WriteLine(tens.ToString());
            Console.WriteLine(twenties.ToString());

            // add rounded coin values + note values, convert total to decimal
            double totalCoins = pennies.getTotalValue() + nickels.getTotalValue() + dimes.getTotalValue() + quarters.getTotalValue();
            double totalNotes = ones.getTotalValue() + fives.getTotalValue() + tens.getTotalValue() + twenties.getTotalValue();
            double totalMoney = Math.Round(totalCoins + totalNotes, 2);

            // calculate total weight of coins
            double totalWeight = pennies.getTotalWeight() + nickels.getTotalWeight() + dimes.getTotalWeight() + quarters.getTotalWeight();
            totalWeight = Math.Round(totalWeight, 3);

            // display total value & total weight of coins
            Console.WriteLine("\nTotal money is $" + totalMoney.ToString() + ". Total weight is " + totalWeight.ToString() + " oz.\n");


            // PART 2: USE ON HAND COINS/NOTES TO CALCULATE CHANGE FOR USER INPUT
            Console.WriteLine("Enter the total needed in USD. Do not include '$'.");  // prompt for USD amount
            string userInp = Console.ReadLine();

            // validate input is a numeric decimal
            if (Decimal.TryParse(userInp, out decimal inpAmt))  // inpAmt = running total of amount to dispense
            {
                // valid input
                Console.WriteLine("\nYou entered: $" + inpAmt.ToString() + "\n");
            }
            else
            {
                // invalid input               
                while(!Decimal.TryParse(userInp, out inpAmt))  // while TryParse fails
                {
                    Console.WriteLine("\nPlease enter a valid USD amount using only integers and a decimal if needed. Do not include the '$'.");
                    userInp = Console.ReadLine();  // reprompt input
                }
            }

            // round inpAmt to 2 decimals in case more were entered
            inpAmt = Math.Round(inpAmt, 2);  // didn't work as expected...
            
            // once input is validated, verify input > 0
            if (inpAmt > 0)
            {                
                // global vars for tracking each note/coin dispensed
                int num20s = 0;
                int num10s = 0;
                int num5s = 0;
                int num1s = 0;
                int numQs = 0;
                int numDs = 0;
                int numNs = 0;
                int numPs = 0;

                // convert coin values to decimal for comparison
                decimal deciQuart = Convert.ToDecimal(0.25);
                decimal deciDime = Convert.ToDecimal(0.10);
                decimal deciNick = Convert.ToDecimal(0.05);
                decimal deciPenn = Convert.ToDecimal(0.01);

                // check if input > 20, if so, decr by 20 until out of on hand 20s
                if (inpAmt >= 20)
                {
                    while((inpAmt - 20 >= 0) && (twenties.getQuantityOnHand() > 0))
                    {
                        inpAmt -= 20;                  // decrement input by note value
                        num20s++;                      // increment note tracker
                        twenties.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a $20 note.");
                    }                                          
                }
                // check if remaining inp > 10, if so, decr by 10 until out of on hand 10s
                if(inpAmt >= 10)
                {
                    while ((inpAmt - 10 >= 0) && (tens.getQuantityOnHand() > 0))
                    {
                        inpAmt -= 10;              // decrement input by note value
                        num10s++;                  // increment note tracker
                        tens.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a $10 note.");
                    }
                }
                // check if remaining inp > 5, if so, decr by 5 until out of on hand 5s
                if(inpAmt >= 5)
                {
                    while ((inpAmt - 5 >= 0) && (fives.getQuantityOnHand() > 0))
                    {
                        inpAmt -= 5;                // decrement input by note value
                        num5s++;                    // increment note tracker
                        fives.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a $5 note.");
                    }
                }
                // check if remaining inp > 1, if so, decr by 1 until out of on hand 1s
                if (inpAmt >= 1)
                {
                    while ((inpAmt - 1 >= 0) && (ones.getQuantityOnHand() > 0))
                    {
                        inpAmt -= 1;               // decrement input by note value
                        num1s++;                   // increment note tracker
                        ones.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a $1 note.");
                    }
                }
                // check if remaining inp > 0.25, if so, decr by 0.25 until out of on hand quarters
                if (inpAmt >= deciQuart)
                {
                    while ((inpAmt - deciQuart >= 0) && (quarters.getQuantityOnHand() > 0))
                    {
                        inpAmt -= deciQuart;           // decrement input by note value
                        numQs++;                       // increment note tracker
                        quarters.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a quarter.");
                    }
                }
                // check if remaining inp > 0.10, if so, decr by 0.10 until out of on hand dimes
                if (inpAmt >= deciDime)
                {
                    while ((inpAmt - deciDime >= 0) && (dimes.getQuantityOnHand() > 0))
                    {
                        inpAmt -= deciDime;           // decrement input by note value
                        numDs++;                      // increment note tracker
                        dimes.decreaseQuantity(1);    // decrement on hand quantity
                        Console.WriteLine("Give them a dime.");
                    }
                }
                // check if remaining inp > 0.05, if so, decr by 0.05 until out of on hand nickels
                if (inpAmt >= deciNick)
                {
                    while ((inpAmt - deciNick >= 0) && (nickels.getQuantityOnHand() > 0))
                    {
                        inpAmt -= deciNick;            // decrement input by note value
                        numNs++;                       // increment note tracker
                        nickels.decreaseQuantity(1);   // decrement on hand quantity
                        Console.WriteLine("Give them a nickel.");
                    }
                }
                // check if remaining inp > 0.01, if so, decr by 0.01 until out of on hand pennies
                if(inpAmt >= deciPenn)
                {
                    while ((inpAmt - deciPenn >= 0) && (pennies.getQuantityOnHand() > 0))
                    {
                        inpAmt -= deciPenn;           // decrement input by note value
                        numPs++;                      // increment note tracker
                        pennies.decreaseQuantity(1);  // decrement on hand quantity
                        Console.WriteLine("Give them a penny.");
                    }
                }

                // PART 3: DISPLAY REMAINING VALUE & WEIGHT OF NOTES/COINS ON HAND
                if (inpAmt > 0)  // then ran out of notes/coins before reaching input amount
                {
                    // if all notes/coins used before reaching input amount
                    Console.WriteLine("\nERR: No money left! $" + inpAmt.ToString() + " still owed to user!");  // inpAmt = running total
                    Console.WriteLine("(Remaining total: $0.00. Remaining weight: 0 oz.)");  // no money left = no value or weight
                }
                else
                {
                    // if input amount reached, get remaining on hand total value & coins weight
                    decimal remainingValue = (Convert.ToDecimal(totalMoney) - inpAmt);  // get value of remaining notes/coins on hand
                    double newCoinsWeight = quarters.getTotalWeight() + dimes.getTotalWeight() + nickels.getTotalWeight() + pennies.getTotalWeight();
                    newCoinsWeight = Math.Round(newCoinsWeight, 3);
                    // display remaining total value & coins weight
                    Console.WriteLine("\nSuccessfully dispensed $" + userInp + " to user. ");  // use userInp to display amount dispensed
                    Console.WriteLine("(Remaining total on hand: $" + remainingValue.ToString() + ". Remaining weight: " + newCoinsWeight.ToString() + " oz.)");
                }               
            }
        }
    }
}
