// Joshua Gregory; June 2024
// Store Inventory Driver File
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Lab2_JoshuaGregory
{
    internal class Program
    {
        private static string greeting = "YakkyTack - Global supplier of yak's milk and hardtack since yesterday! (TM)";
        private static string menu = "\nYakkyTack Inventory Management:\n  1. Sell yak milk\n  2. Sell one hardtack bread\n  3. Change price of yak milk\n  4. Change price of hardtack bread\n  5. Raise yak milk inventory\n  6. Riase hardtack bread inventory\n  7. View inventory\n  8. Exit\n";

        static void Main(string[] args)
        {
            // create StockItem obj for milk & StockItem obj for bread
            StockItem milk = new StockItem("1 gallon bag of yak milk", 3.60, 15);
            StockItem bread = new StockItem("1 loaf of hardtack bread", 1.98, 30);

            // array of inventory objects
            StockItem[] inventory = new StockItem[2];
            inventory[0] = milk;
            inventory[1] = bread;
            
            // begin program
            Console.WriteLine(greeting);
            do
            {
                Console.WriteLine(menu);
                string userInp = Console.ReadLine();

                // OPTION 1: SELL MILK
                if(userInp == "1")
                {
                    if(milk.GetQty() - 1 < 0)
                    {
                        // not enough milk to sell
                        Console.WriteLine("Sorry, you are out of yak's milk. Restock and try again.\n");
                        continue;
                    }
                    else
                    {
                        // enough milk, lower qty, show new qty
                        Console.WriteLine("You sold one bag of yak's milk. Great job!");
                        milk.LowerQty(1);
                        Console.WriteLine("You have " + milk.GetQty() + " bags of yak's milk left.\n");
                        continue;
                    }  
                }

                // OPTION 2: SELL BREAD
                if(userInp == "2")
                {
                    if(bread.GetQty() - 1 < 0)
                    {
                        // not enough bread to sell
                        Console.WriteLine("Sorry, you are out of hardtack bread. Restock and try again.");
                        continue;
                    }
                    else
                    {
                        // enough bread, lower qty, show new qty
                        Console.WriteLine("You sold a loaf of hardtack bread. Great job!");
                        bread.LowerQty(1);
                        Console.WriteLine("You have " + bread.GetQty() + " loafs of hardtack bread left.\n");
                        continue;
                    }
                }

                // OPTION 3: CHANGE MILK PRICE
                if(userInp == "3")
                {
                    // get input for new milk price, convert to double
                    Console.WriteLine("Enter the new yak's milk price:");
                    string newMilkPrice = Console.ReadLine();
                    double p = Convert.ToDouble(newMilkPrice);

                    // verify price is valid, reprompt if not
                    while(true)
                    {
                        if (p <= 0.0)
                        {
                            // invalid price, reprompt input
                            Console.WriteLine("Please enter a positive, non-zero price.");
                            newMilkPrice = Console.ReadLine();
                            p = Convert.ToDouble(newMilkPrice);
                            continue;
                        }
                        else
                        {
                            // set input to new milk price
                            milk.SetPrice(p);
                            Console.WriteLine("Gallon bags of yak's milk now cost $" + milk.GetPrice() + ".\n");
                            break;
                        }
                    }                   
                }

                // OPTION 4: CHANGE BREAD PRICE
                if(userInp == "4")
                {
                    // get input for new bread price, convert to double
                    Console.WriteLine("Enter the new hardtack bread price:");
                    string newBreadPrice = Console.ReadLine();
                    double p = Convert.ToDouble(newBreadPrice);

                    // verify price is valid, reprompt if not
                    while(true)
                    {
                        if (p <= 0.0)
                        {
                            // invalid price, reprompt input
                            Console.WriteLine("Please enter a positive, non-zero price.");
                            newBreadPrice = Console.ReadLine();
                            p = Convert.ToDouble(newBreadPrice);
                            continue;
                        }
                        else
                        {
                            // set input to new milk price
                            bread.SetPrice(p);
                            Console.WriteLine("Loafs of hardtack bread now cost $" + bread.GetPrice() + ".\n");
                            break;
                        }
                    }
                }

                // OPTION 5: RAISE MILK INVENTORY
                if (userInp == "5")
                {
                    // get input for new milk qty, convert to int
                    Console.WriteLine("Enter the number of bags of yak's milk to add to inventory:");
                    string newMilkQty = Console.ReadLine();
                    int n = Convert.ToInt32(newMilkQty);

                    // verify qty is valid, reprompt if not
                    while (true)
                    {
                        if (n <= 0)
                        {
                            // invalid qty, reprompt input
                            Console.WriteLine("Please enter a positive, non-zero quantity.");
                            newMilkQty = Console.ReadLine();
                            n = Convert.ToInt32(newMilkQty);
                            continue;
                        }
                        else
                        {
                            // set input to milk qty
                            milk.RaiseQty(n);
                            Console.WriteLine("You now have " + milk.GetQty() + " bags of yak's milk.\n");
                            break;
                        }
                    }
                }

                // OPTION 6: RAISE BREAD INVENTORY
                if(userInp == "6")
                {
                    // get input for new bread qty, convert to int
                    Console.WriteLine("Enter the number of loafs of hardtack bread to add to inventory:");
                    string newBreadQty = Console.ReadLine();
                    int n = Convert.ToInt32(newBreadQty);

                    // verify qty is valid, reprompt if not
                    while(true)
                    {
                        if(n <= 0)
                        {
                            // invalid qty, reprompt input
                            Console.WriteLine("Please enter a positive, non-zero quantity.");
                            newBreadQty = Console.ReadLine();
                            n = Convert.ToInt32(newBreadQty);
                            continue;
                        }
                        else
                        {
                            // set input to bread qty
                            bread.RaiseQty(n);
                            Console.WriteLine("You now have " + bread.GetQty() + " loafs of bread.\n");
                            break;
                        }
                    }
                }

                // OPTION 7: VIEW INVENTORY
                if(userInp == "7")
                {
                    Console.WriteLine("Current inventory:");
                    // traverse inventory array, call ToString on each object
                    for(int i = 0; i < inventory.Length; i++)
                    {
                        Console.WriteLine(inventory[i].ToString());
                    }
                }

                // OPTION 8: EXIT
                if(userInp == "8")
                {
                    Console.WriteLine("Thank you for using YakkyTack Inventory Management. Don't forget to lock up!");
                    break;
                }
            } while (true);
        }
    }
}
