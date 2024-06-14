// Joshua Gregory; June 2024
// SimpleLibrary driver class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_JoshuaGregory
{
    internal class myCollection
    {
        // create an Item[] to store 5 books/periodicals (polymporphism)
        public static Item[] myItems = new Item[5];

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SimpleLibrary (@)-(@)");

            // prompt user to enter 5 books/periodicals
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("\nEnter 'B' to add a book or 'P' to add a periodical:");
                string userInp = Console.ReadLine();

                if (userInp == "B" || userInp == "b")
                {
                    // get title, ISBN, author
                    Console.WriteLine("What is the title of the book?");
                    string inpTitle = Console.ReadLine();
                    Console.WriteLine("What is the ISBN of the book?");
                    string inpISBN = Console.ReadLine();
                    Console.WriteLine("Who is the author of the book?");
                    string inpAuthor = Console.ReadLine();

                    // create book obj, add to ith idx, increment i
                    Book myBook = new Book(inpTitle, inpISBN, inpAuthor);
                    myItems[i] = myBook;
                    i++;
                }
                else if (userInp == "P" || userInp == "p")
                {
                    // get title, issue number
                    Console.WriteLine("What is the title of the periodical?");
                    string inpTitle = Console.ReadLine();
                    Console.WriteLine("What is the issue number of the periodical?");
                    int inpIssue = Convert.ToInt32(Console.ReadLine());

                    // create periodical obj, add to ith idx, increment i
                    Periodical myPeriodical = new Periodical(inpTitle, inpIssue);
                    myItems[i] = myPeriodical;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            // display collection attributes when full
            if (myItems.Length == 5)
            {
                Console.WriteLine("\nCollection is full. The items in your current library are:");
                for (int j = 0; j < myItems.Length; j++)
                {
                    Console.WriteLine(myItems[j].getListing());
                }
            }
        }
    }
}