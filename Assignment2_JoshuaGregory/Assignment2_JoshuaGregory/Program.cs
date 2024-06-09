// Joshua Gregory; June 2024
// Word Guessing Game Driver File
// Requires English.cs that contains a List of 900 common English words.
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Assignment2_JoshuaGregory
{
    internal class Program
    {
        /**
         * Seaches a string for a given char.
         * @param string 'word' from English.cs
         * @param char   'letter' to find in 'word'
         * @return bool true if 'word' contains 'letter'
         */
        public static bool wordContainsLetter(string word, char letter)
        {
            // convert string input to char arr
            char[] wordArr = word.ToCharArray();

            // iterate thru wordArr to see if it contains letter
            for(int i = 0; i < wordArr.Length; i++)
            {
                // returns as soon as letter is found
                return wordArr[i].Equals(letter);
            }
            return false;  // char not in char arr
        }

        /**
         * Searches a string for a given substring.
         * @param  string 'word' from English.cs
         * @param  string 'sub' to find in 'word'
         * @return bool true if 'str' contains 'sub)
         */
        public static bool wordContainsString(string word, string sub)
        {
            return word.Contains(sub);
        }

        /**
         * Displays each English object of 'len' length that contains 'letters'.
         * (Eg: len = 3, letters = "ct", matches = "act", "cat", etc.)
         * @param English 'words' lisst of words in English.cs
         * @param int 'len' length of English object words
         * @param string 'pattern' to search for in 'wordList'
         */
        public static void guessWordWithLetters(English wordList, int len, string letters)
        {
            // construct English object (List of 900 words)
            wordList = new English();

            // convert letters to char array
            char[] lettersArr = letters.ToCharArray();

            // list to store words that meet conditions
            List<string> matchList = new List<string>();

            // check for conditions
            foreach (string word in wordList.words)
            {
                if (word.Length == len)
                {
                    if (wordContainsString(word, letters))
                    {
                        matchList.Add(word);  // add to match list
                    }
                }
            }

            // check if words were found
            if (matchList.Count <= 0)
            {
                System.Console.WriteLine($"Unable to find {len} letters long words containing {letters}.");
            }
            else
            {
                Console.WriteLine($"\nWords with {len} letters and containing {letters}:");
                foreach (string word in matchList)
                {
                    System.Console.WriteLine(word);  // display words that match conditions
                }
            }
        }

        /**
         * Displays each English object of 'len' length that contains 'pattern'.
         * (Eg: len = 3, pattern = "at", matches = "cat", "bat", "rat", etc.)
         * @param English 'words' lisst of words in English.cs
         * @param int 'len' length of English object words
         * @param string 'pattern' to search for in 'wordList'
         */
        public static void guessWordWithPattern(English wordList, int len, string pattern)
        {
            // construct English object (List of 900 words)
            wordList = new English();

            // list to store words that meet conditions
            List<string> matchList = new List<string>();

            // find words in wordList that contain each char in 'letters'
            foreach (string word in wordList.words)
            {
                // check if word contains each char in 'letters'
                if(word.Length == len && wordContainsString(word, pattern))
                {
                    matchList.Add(word);  // add to match list
                }
            }

            // check if words were found
            if (matchList.Count <= 0)
            {
                System.Console.WriteLine($"Unable to find {len} letters long words containing {pattern}.");
            }
            else
            {
                Console.WriteLine($"\nWords with {len} letters and containing {pattern}:");
                foreach (string word in matchList)
                {
                    System.Console.WriteLine(word);  // display words that match conditions
                }
            }
        }

        /**
         * Searches English object of 'len' length for char 'letter'.
         * @param English obj (from English class, ie 1 of 900 words)
         * @param int len (length of English object words)
         * @param char letter (to search for in 'obj')
         */
        //publiic static void guessWordWithPattern(English obj, int len, string)

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word Guessing Game!");

            string menu = "\n1. Guess a word with letters\n" +
                          "2. Guess a word with a pattern\n" +
                          "3. Exit\n";

            do
            {
                Console.WriteLine(menu);
                string userInp = Console.ReadLine();

                if (userInp == "1")
                {
                    // get word length
                    Console.WriteLine("How many letters are in the word?");
                    string lenInp = Console.ReadLine();

                    if (Int32.TryParse(lenInp, out int len))
                    {
                        // get letters to look for
                        Console.WriteLine("What letters are in the word?");
                        string letters = Console.ReadLine();

                        // validate letters input
                        bool isValidAlpha = Regex.IsMatch(letters, @"^[a-zA-Z]+$");
                        if (isValidAlpha)
                        {
                            // valid input -> construct English object, call method
                            English obj = new English();
                            guessWordWithLetters(obj, len, letters);
                        }
                        else
                        {
                            while (!isValidAlpha)
                            {
                                Console.WriteLine("Invalid input. Please enter only letters.");
                                letters = Console.ReadLine();
                                isValidAlpha = Regex.IsMatch(letters, @"^[a-zA-Z]+$");
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
                else if (userInp == "2")
                {
                    // get word length
                    Console.WriteLine("How many letters are in the word?");
                    string lenInp = Console.ReadLine();

                    // validate length input
                    if (Int32.TryParse(lenInp, out int len))
                    {
                        // get pattern to look for
                        Console.WriteLine("What pattern is in the word?");
                        string pattern = Console.ReadLine();

                        // validate pattern input
                        bool isValidAlpha = Regex.IsMatch(pattern, @"^[a-zA-Z]+$");
                        if (isValidAlpha)
                        {
                            // valid input -> construct English object, call method
                            English obj = new English();
                            guessWordWithPattern(obj, len, pattern);
                        }
                        else
                        {
                            while (!isValidAlpha)
                            {
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
                else if (userInp == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (1, 2, or 3.)");
                }
            } while (true);
        }
    }
}
