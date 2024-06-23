// Joshua Gregory; June 2024
// RandNumGuess Game logic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_JoshuaGregory
{
    internal class GuessNumber
    {
        // instance fields
        public static Random rand = new Random();  // random num picker

        // METHOD: parse user guess to int & handle exceptions
        public static int parseGuess(string userGuess)
        {
            do
            {
                if(!Int32.TryParse(userGuess, out int n))  // invaid, reprompt
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    userGuess = Console.ReadLine();
                }
                else
                {
                    return n;  // valid, return int
                }
            } while (true);
        }

        // METHOD: compare guess to random num
        public static void checkGuess(int guess, int rdm, Language lang)
        {
            do
            {
                if (guess < rdm)  // guess too low
                {
                    Console.WriteLine(lang.tooLow());
                    guess = parseGuess(Console.ReadLine());  // input to int parser
                }
                else if (guess > rdm)  // guess too high
                {
                    Console.WriteLine(lang.tooHigh());
                    guess = parseGuess(Console.ReadLine());  // intput to int parser
                }
                else  // correct
                {
                    Console.WriteLine(lang.correct());
                    break;
                }
            } while (true);
        }

        // METHOD: game logic
        public void playGame()
        {
            Console.WriteLine("Choose a language in which to play:\n1. English\n2. Español\n3. Français\n4. 简体中文");
            string langChoice = Console.ReadLine();

            // ENGLISH
            if (langChoice == "1")
            {
                Language gameLang = new English();                   // init child on parent constr
                gameLang = (English)gameLang;                        // cast to child English
                Console.WriteLine(gameLang.makeGuess());             // display makeGuess()
                int guessInt = parseGuess(Console.ReadLine());       // input parser method
                int rdmInt = rand.Next(0, 101);                      // get random int [0,100]
                checkGuess(guessInt, rdmInt, gameLang);              // guess checker method
            }
            // SPANISH
            if (langChoice == "2")
            {
                Language gameLang = new Spanish();                   // init child on parent constr
                gameLang = (Spanish)gameLang;                        // cast to child English
                Console.WriteLine(gameLang.makeGuess());             // display makeGuess()
                int guessInt = parseGuess(Console.ReadLine());       // input parser method
                int rdmInt = rand.Next(0, 101);                      // get random int [0,100]
                checkGuess(guessInt, rdmInt, gameLang);              // guess checker method
            }
            // FRENCH
            if (langChoice == "3")
            {
                Language gameLang = new French();                    // init child on parent constr
                gameLang = (French)gameLang;                         // cast to child English
                Console.WriteLine(gameLang.makeGuess());             // display makeGuess()
                int guessInt = parseGuess(Console.ReadLine());       // input parser method
                int rdmInt = rand.Next(0, 101);                      // get random int [0,100]
                checkGuess(guessInt, rdmInt, gameLang);              // guess checker method
            }
            // SIMPLIFIED CHINESE
            if (langChoice == "4")
            {
                Language gameLang = new SimplifiedChinese();         // init child on parent constr
                gameLang = (SimplifiedChinese)gameLang;              // cast to child English
                Console.WriteLine(gameLang.makeGuess());             // display makeGuess()
                int guessInt = parseGuess(Console.ReadLine());       // input parser method
                int rdmInt = rand.Next(0, 101);                      // get random int [0,100]
                checkGuess(guessInt, rdmInt, gameLang);              // guess checker method
            }
        }
    }
}
