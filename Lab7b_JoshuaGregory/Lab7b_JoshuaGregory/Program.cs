// Joshua Gregory; June 2024
// Lab 7b; String recursion
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Lab7b_JoshuaGregory
{
    internal class Program7b
    {
        // METHOD: concatenate input string n times
        public static string repeatNTimes(string strInp, int n)
        {
            if (n == 0)
            {
                return "";      // base case 0
            }
            else if (n == 1)
            {
                return strInp;  // base case 1
            }
            // eg: (yo,2) -> yo + (yo,1) -> yo + yo -> yoyo
            return strInp + repeatNTimes(strInp, n - 1);
        }

        // METHOD: checks if input strings are palindromes
        // Note: this is a LeetCode problem that I've solved in Python & JavaScript, now I can submit a C# solution :)
        public static bool isReverse(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;   // base case 0
            }
            else if (str1 == "" && str2 == "")
            {
                return true;    // base case 1
            }
            else
            {
                int i, j; int strLen = str1.Length;
                for (i = 0, j = strLen-1; i < strLen; i++, j--)
                {
                    if (str1[i] != str2[j])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        // MEHTOD: get user string input
        public static string strInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // METHOD: get N times to repeat string
        public static int inputN(string prompt)
        {
            Console.Write(prompt);
            string strN = Console.ReadLine();

            // validate input & convert to int
            while(true)
            {
                if(!Int32.TryParse(strN, out int n))
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer only.");
                    strN = Console.ReadLine();
                }
                else
                {
                    return n;
                }
            }
        }

        // MAIN: program UI
        static void Main(string[] args)
        {
            // print study phrase 100 times
            Console.WriteLine(repeatNTimes("I must study recursion until it makes sense!\n", 100));

            string menu = "\n1. Repeat a string N times\n2. Check if two strings are palindromes\n3. Exit\n";
            string s1, s2;

            do
            {
                Console.WriteLine("\nEnter an option from below:" + menu);
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":  // repeat N times
                        s1 = strInput($"Enter the string you want repeated: ");
                        int n = inputN("How many times do you want the string repeated? ");
                        Console.WriteLine(repeatNTimes(s1, n));
                        break;

                    case "2":  // check if palindromes
                        s1 = strInput("Enter the first string: ");
                        s2 = strInput("Enter the second string: ");
                        if (isReverse(s1, s2))
                        {
                            Console.WriteLine($"The strings '{s1}' and '{s2}' are the reverse of each other. They are palindromes!");
                        }
                        else
                        {
                            Console.WriteLine($"The strings '{s1}' and '{s2}' are not the reverse of each other. They are not palindromes.");
                        }
                        break;
                    case "3":  // exit
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid input.");                       
                        break;
                }
            } while (true);
        }
    }
}
