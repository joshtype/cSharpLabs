// Joshua Gregory; June 2024
// Word Guessing Game Driver File
// (Requires English.cs that contains a List of 900 common English words.)
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Assignment2_JoshuaGregory
{
    internal class Program
    {
        // Method 1: Searches string 'word' for occurrence of char 'letter'.
        // See BugLog.txt for bug in previous version's and the fix.
        public static bool wordContainsLetter(string word, char letter)
        {
            char[] wordArr = word.ToCharArray();        // convert string input to char[]
            for (int i = 0; i < wordArr.Length; i++)    // iterate char[], compare to letter
            {
                if (wordArr[i] == letter)
                {
                    return true;  // current index == char input
                }
            }
            return false;         // indinces != char input
        }


        // Method 2: Searches string 'word' for substring 'sub'.
        public static bool wordContainsString(string word, string sub)
        {
            return word.Contains(sub);
        }


        // Searches English object for words of 'len' length in which each char in 'letters' occurs 1+ times.
        public static void guessWordWithLetters(English wordList, int len, string letters)
        {
            wordList = new English();                     // Init English object (List of 900 words)
            List<string> matchList = new List<string>();  // List to store matching words
            bool eachLetter = false;                      // True if current char found, else false

            foreach (string word in wordList.words)       // check each word for each char
            {               
                int i = 0;
                while(i < letters.Length)                 // iterate each char in 0-indexed string input
                {
                    if (wordContainsLetter(word, letters[i]))
                    {
                        eachLetter = true;               // current char in current word
                    }
                    else
                    {
                        eachLetter = false;              // current char not in current word
                        break;                           // break loop, no need to continue
                    }
                    i++;                                 // move to next char
                }
                if (word.Length == len && eachLetter)    // if word.length = len & eachLetter = true
                {
                    Console.WriteLine(word);             // display word
                }
            }
        }


        // Displays each English object of 'len' length that contains 'pattern'.
        public static void guessWordWithPattern(English wordList, int len, string pattern)
        {
            wordList = new English();                       // construct English object (List of 900 words)
            List<string> matchList = new List<string>();    // List to store matching words

            // Iterate thru words, check for length, then check for substring
            foreach (string word in wordList.words)
            {
                if (word.Length == len && wordContainsString(word, pattern))
                {
                    Console.WriteLine(word);  // add to List
                }
            }           
        }
      

        // Driver method for game UI & logic.
        static void Main(string[] args)
        {
            // Greeting & UI menu
            Console.WriteLine("Welcome to WordGuesser!");
            string menu = "\nWhat would you like to do?" +
                "\n1. Guess a word with letters" +
                "\n2. Guess a word with a patter" +
                "\n3. Exit\n";
            // Loop guessing game until user exits
            do
            {
                // Display menu, read user choice
                Console.WriteLine(menu);
                string userInp = Console.ReadLine();

                // Letters
                if (userInp == "1")
                {
                    // get input for word length
                    Console.WriteLine("How many letters are in the word?");
                    string lenInp = Console.ReadLine();

                    // validate & convert string lenInp to int len (while handling exceptions)
                    if (Int32.TryParse(lenInp, out int len))
                    {
                        // if len = valid, get input for letters chars
                        Console.WriteLine("What letters are in the word?");
                        string letters = Console.ReadLine();

                        // validate letters = alpha only
                        bool isValidAlpha = Regex.IsMatch(letters, @"^[a-zA-Z]+$");
                        if (isValidAlpha)
                        {
                            Console.WriteLine($"\nWords with {len} letters and contain '{letters}' characters:");
                            // letters = valid: create object & pass obj & user inputs to method
                            English obj = new English();
                            guessWordWithLetters(obj, len, letters);
                        }
                        else
                        {
                            while (!isValidAlpha)
                            {
                                // letters = invalid: reprompt & revalidate until input is valid
                                Console.WriteLine("Invalid input. Please enter only letters.");
                                letters = Console.ReadLine();
                                isValidAlpha = Regex.IsMatch(letters, @"^[a-zA-Z]+$");
                            }
                        }
                    }
                    else
                    {
                        // lenInp = invalid: reprompt & revalidate until valid
                        while (!Int32.TryParse(lenInp, out len))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            lenInp = Console.ReadLine();
                        }
                    }
                }
                // Pattern
                else if (userInp == "2")
                {
                    // get input for word length
                    Console.WriteLine("How many letters are in the word?");
                    string lenInp = Console.ReadLine();

                    // validate & convert len input to int (while handling exceptions)
                    if (Int32.TryParse(lenInp, out int len))
                    {
                        // if len = valid, get input for pattern substring
                        Console.WriteLine("What pattern is in the word?");
                        string pattern = Console.ReadLine();

                        // validate pattern = alpha only
                        bool isValidAlpha = Regex.IsMatch(pattern, @"^[a-zA-Z]+$");
                        if (isValidAlpha)
                        {
                            Console.WriteLine($"\nWords with {len} letters and contain a '{pattern}' pattern:");
                            English obj = new English();              // if valid, create English object
                            guessWordWithPattern(obj, len, pattern);  // pass obj & user inputs to method
                        }
                        else
                        {
                            while (!isValidAlpha)
                            {
                                // reprompt & revalidate until input is valid
                                Console.WriteLine("Invalid input. Please enter only letters.");
                                pattern = Console.ReadLine();
                                isValidAlpha = Regex.IsMatch(pattern, @"^[a-zA-Z]+$");
                            }
                        }
                    }
                    else
                    {
                        while (!Int32.TryParse(lenInp, out len))
                        {
                            // non-integer input, reprompt
                            Console.WriteLine("Invalid input. Please enter a number.");
                            lenInp = Console.ReadLine();
                        }
                    }
                }
                // Exit
                else if (userInp == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // UI input = invalid: reprompt until input = valid
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (1, 2, or 3.)");
                }
            } while (true);  // loop breaks only when user inputs "3" to exit game
        }
    }
}
