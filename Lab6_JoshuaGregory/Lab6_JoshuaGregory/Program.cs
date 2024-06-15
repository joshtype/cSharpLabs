// Joshua Gregory; 2024
// Nth Fibonacci driver file
// Interfacing & Implementing
namespace Lab6_JoshuaGregory
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            do
            {
                // prompt user for n
                Console.WriteLine("\nEnter an integer n to calculate Fibonacci of n: ");

                // read and validate input, convert to int n
                string inpN = Console.ReadLine();
                int n;

                while (true)
                {
                    if (!Int32.TryParse(inpN, out n) || n <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer.");
                        inpN = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                // instantiate FibIteration & FibFormula objs
                FibIteration fibo1 = new FibIteration();
                Console.WriteLine($"Iterative: The {n}th term in the Fibonacci Sequence is " + fibo1.calculateFib(n));
                FibFormula fibo2 = new FibFormula();
                Console.WriteLine($"Formulaic: The {n}th term in the Fibonacci Sequence is " + fibo2.calculateFib(n));

                Console.WriteLine("\nWould you like to calculate another Fibonacci number? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "n")
                {
                    break;
                }

            } while (true);

            
        }
    }
}
