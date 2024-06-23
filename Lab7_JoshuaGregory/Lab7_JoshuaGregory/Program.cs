// Joshua Gregory; 2024
// Lab 7a; Recursive math
namespace Lab7_JoshuaGregory
{
    internal class Program
    {
        // METHOD: recursive multiplication
        public static int recursiveMult(int fctr1, int fctr2)
        {
            switch (fctr1, fctr2)
            {
                case (0, _):
                    return 0;
                case (_, 0):
                    return 0;
                case (1, _):
                    return fctr2;
                case (_, 1):
                    return fctr1;
                default:
                    // (x + x) until y = 0
                    return fctr1 + recursiveMult(fctr1, fctr2 - 1);
            }
        }
        // METHOD: recursive division
        public static int recursiveDiv(int dvnd, int dvsr)
        {
            if (dvnd == dvsr)
            {
                return 1;
            }
            else if (dvnd < dvsr)
            {
                return 0;
            }
            else
            {
                switch (dvnd, dvsr)
                {                     
                    case (0, _):            // 0/x = 0
                        return 0;           
                    case (_, 0):            // x/0 = undefined
                        return -1;          
                    case (1, _):            // 1/x = 0
                        return 0;           
                    case (_, 1):            // x/1 = x
                        return dvnd;    
                    default:                // dvnd-dvsr till dvnd < dvsr
                        return 1 + recursiveDiv(dvnd - dvsr, dvsr);
                }               
            }           
        }
        // METHOD: recursive modulus
        public static int recursiveModulus(int dvnd, int dvsr)
        {
            // 10%3 = 1 bc 10/3 = q3,r1
            if (dvnd < dvsr) 
            {
                return dvnd;
            }
            else
            {
                switch (dvnd, dvsr)
                {
                    case (_,0):
                        return -1;
                    case (0, _):
                        return 0;
                    case (1, _):
                        return 1;
                    case (_, 1):
                        return 0;
                    default:
                        return recursiveModulus(dvnd - dvsr, dvsr);
                }
            }
        }
        // METHOD: get, validate, convert to int x
        public static int inputX()
        {
            // get, validate, convert to int x
            Console.WriteLine("Enter the first integer: ");
            string userX = Console.ReadLine();
            while(true)
            {
                if (!int.TryParse(userX, out int x))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    userX = Console.ReadLine();
                }
                else
                {
                    return x;
                }
            }
        }
        // METHOD: get, validate, convert to int y
        public static int inputY()
        {
            // get, validate, convert to int y
            Console.WriteLine("Enter the second integer: ");
            string userY = Console.ReadLine();
            while(true)
            {
                if (!int.TryParse(userY, out int y))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    userY = Console.ReadLine();
                }
                else
                {
                    return y;
                }
            }
        }
        // MAIN: program UI
        static void Main(string[] args)
        {
            string menu = "\nChoose a recursion type:\n0: Exit\n1. Multiply 2 integers\n2. Divide 2 integers\n3. Modulo 2 integers\n";
            string userChoice;
            string userX, userY;
            int x, y, result;

            do
            {
                Console.WriteLine(menu);
                userChoice = Console.ReadLine();

                switch(userChoice)
                {
                    // exit
                    case "0":  
                        Console.WriteLine("Goodbye!");
                        return;
                    // multipy
                    case "1":
                        x = inputX();                               // get int x
                        y = inputY();                               // get int y
                        result = recursiveMult(x, y);               // call recur
                        Console.WriteLine($"{x} x {y} = {result}"); // show result
                        break;                                      // reloop menu
                    // divide
                    case "2":
                        x = inputX();
                        y = inputY();
                        Console.WriteLine($"{x} / {y} = {recursiveDiv(x, y)}");
                        break;
                    // modulus
                    case "3":
                        x = inputX();
                        y = inputY();
                        Console.WriteLine($"{x} % {y} = {recursiveModulus(x, y)}");
                        break;
                    // invalid input
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }

            } while (true);
        }
    }
}
