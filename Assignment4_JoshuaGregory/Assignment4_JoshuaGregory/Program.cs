// Joshua Gregory; June 2024
// RandNumGuess Driver & UI
namespace Assignment4_JoshuaGregory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop game UI till user exits
            Console.WriteLine("Welcome to PseudoGuesser! I'll pick a pseudorandom [0,100] integer. Just choose a language and start guessing!");
            do
            {
                Console.WriteLine("\nWant to play? [y/n]");
                string yesNo = Console.ReadLine();

                if (yesNo == "y" || yesNo == "Y")
                {
                    GuessNumber game = new GuessNumber();
                    game.playGame();
                }
                else if(yesNo == "n" || yesNo == "N")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    yesNo = Console.ReadLine();
                }
            } while (true);            
        }
    }
}
