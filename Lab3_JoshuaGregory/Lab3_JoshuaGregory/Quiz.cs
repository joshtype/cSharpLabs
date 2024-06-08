// Joshua Gregory; June 2024
// Quiz Maker -> Quiz Class File
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab3_JoshuaGregory
{
    internal class Quiz
    {
        // class attributes (List of Question objs)
        private static List<Question> qList = new List<Question>();

        /**
         * Constructs & adds a Question object to List. 
         */
        public void addQuestion()
        {
            // prompt user for question text
            Console.WriteLine("Question text:");
            string newText = Console.ReadLine();

            // prompt user for question answer
            Console.WriteLine("Question answer:");
            string newAnsr = Console.ReadLine();

            // prompt user for difficulty level & convert input to int
            Console.WriteLine("Difficulty level (enter '1' for easy, '2' for medium, or '3' for hard):");
            string inpDiff = Console.ReadLine();
            if (Int32.TryParse(inpDiff, out int newDiff))
            {
                // verify input is 1, 2, or 3
                if (newDiff < 1 || newDiff > 3)
                {
                    // invalid input, reprompt
                    while (newDiff < 1 || newDiff > 3)
                    {
                        Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                        inpDiff = Console.ReadLine();
                        // convert the valid input to int
                        Int32.TryParse(inpDiff, out newDiff);
                    }
                }
            }
            else
            {
                // TryParse failed, reprompt
                while (!Int32.TryParse(inpDiff, out newDiff))
                {
                    Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                    inpDiff = Console.ReadLine();
                }
            }

            // construct new Question obj from user input, add to List
            Question newQuestion = new Question(newText, newAnsr, newDiff);
            qList.Add(newQuestion);
        }

        /**
         * Displays text of each question in List, removes user-selected question.
         */
        public void removeQuestion()
        {
            Console.WriteLine("\nYou selected to remove a question from the quiz.");
            // prompt user for question to remove
            if (qList.Count <= 0)
            {
                // no questions in List
                Console.WriteLine("Your quiz is already empty!.");
            }
            else
            {
                // display each question's text for user selection
                Console.WriteLine("Your quiz currently contains the following questions:");
                for (int i = 0; i < qList.Count; i++)
                {
                    // traverse List, print each question's text
                    Console.WriteLine("Question " + (i + 1) + ": " + qList[i].getText());
                }
                // prompt user for question number to remove
                Console.WriteLine("Enter just the number of the question you'd like to remove:");
                string numToRemove = Console.ReadLine();

                // convert user input to int via TryParse
                if (Int32.TryParse(numToRemove, out int numIdx))
                {
                    // conversion successful, remove the question at numIdx-1
                    qList.RemoveAt(numIdx - 1);
                }
                else
                {
                    // conversion failed, reprompt
                    while (!Int32.TryParse(numToRemove, out numIdx))
                    {
                        Console.WriteLine("Invalid input. Please enter a number:");
                        numToRemove = Console.ReadLine();
                    }
                }
            }
        }

        /*
         * Modifies a user-selected question in List.
         */
        public void modifyQuestion()
        {
            Console.WriteLine("\nYou selected to modify a question in the quiz.");
            // prompt user for question to remove
            if (qList.Count <= 0)
            {
                // no questions in List
                Console.WriteLine("Your quiz is empty!");
            }
            else
            {
                // display each question's text for user selection
                Console.WriteLine("Your quiz currently contains the following questions:");
                for (int i = 0; i < qList.Count; i++)
                {
                    // traverse List, print each question's text
                    Console.WriteLine("Question " + (i + 1) + ": " + qList[i].getText());
                }
                // prompt user for question number to remove
                Console.WriteLine("Enter just the number of the question you'd like to modify:");
                string numToModify = Console.ReadLine();

                // convert user input to int via TryParse
                if (Int32.TryParse(numToModify, out int numIdx))
                {
                    // conversion successful, modify question text at numIdx-1
                    Console.WriteLine("Enter the new text for the question:");
                    string newText = Console.ReadLine();
                    qList[numIdx - 1].setText(newText);

                    Console.WriteLine("Enter the new answer for the question:");
                    string newAnsr = Console.ReadLine();
                    qList[numIdx - 1].setAnsr(newAnsr);

                    Console.WriteLine("Enter the new difficulty level for the question:");
                    string inpDiff = Console.ReadLine();
                    if (Int32.TryParse(inpDiff, out int newDiff))
                    {
                        // conversion successful, verify newDiff is 1, 2, or 3
                        if (newDiff < 1 || newDiff > 3)
                        {
                            // invalid input, reprompt
                            while (newDiff < 1 || newDiff > 3)
                            {
                                Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                                inpDiff = Console.ReadLine();
                                Int32.TryParse(inpDiff, out newDiff);
                            }
                            // modify question diff at numIdx-1
                            qList[numIdx - 1].setDiff(newDiff);
                        }
                        else
                        {
                            // conversion failed, reprompt
                            while (!Int32.TryParse(inpDiff, out newDiff))
                            {
                                Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                                inpDiff = Console.ReadLine();
                            }
                        }
                        qList[numIdx - 1].setDiff(newDiff);
                    }
                    else
                    {
                        // conversion failed, reprompt
                        while (!Int32.TryParse(numToModify, out numIdx))
                        {
                            Console.WriteLine("Invalid input. Please enter a number:");
                            numToModify = Console.ReadLine();
                        }
                    }
                }
            }
        }

        /**
         * Allows user to take quiz.
         */
        public void giveQuiz()
        {
            Console.WriteLine("\nYou selected to take the quiz. Note: answers must match to score points, including punctuation!");
            int score = 0;  // track number of matching answer strings

            // traverse List, display question text, prompt user for answer
            for (int i = 0; i < qList.Count; i++) 
            {
                // display each question text, read in user answer
                Console.WriteLine("Question " + (i + 1) + ": " + qList[i].getText());
                Console.WriteLine("Enter your answer:");
                string userAnsr = Console.ReadLine();

                // compare user answer to question answer
                if (userAnsr.Equals(qList[i].getAnsr()))
                {
                    // correct answer, increment score
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    // incorrect answer
                    Console.WriteLine("Incorrect. The correct answer is: " + qList[i].getAnsr() + "\n");
                }
            }
            // display score
            Console.WriteLine("You scored " + score + " out of " + qList.Count + " points.");
        }
    }
}
