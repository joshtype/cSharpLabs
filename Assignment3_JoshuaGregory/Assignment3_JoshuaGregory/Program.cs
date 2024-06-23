// Joshua Gregory; June 2024
// PokemonGo; Driver
using System.Security.Cryptography.X509Certificates;

namespace Assignment3_JoshuaGregory
{
    internal class Program
    {
        // instance fields
        public static Random rand = new Random();  // psuedorandom generator
        public static Pokemon poke;                // Pokemon parent obj

        // METHOD: spawn a new pokemon
        public static Pokemon pokeSpawn()
        {
            int rdmType = rand.Next(1, 4);    // 1=Bulbasuar,2=Charmander,3=Caterpie
            int rdmLevel = rand.Next(0, 21);  // random level [0,20]

            // Bulbasaur
            if (rdmType == 1)
            {
                poke = new Bulbasaur(rdmLevel);  // init child on parent constr
                poke = (Bulbasaur)poke;          // cast parent to child
                Console.WriteLine($"\nA wild, {rdmLevel} level Bulbasaur appeared!");
                return poke;
            }
            // Charmander
            else if (rdmType == 2)
            {
                poke = new Charmander(rdmLevel);
                poke = (Charmander)poke;
                Console.WriteLine($"\nA wild, {rdmLevel} level Charmander appeared!");
                return poke;
            }
            // Caterpie
            else
            {
                Pokemon poke = new Caterpie(rdmLevel);
                poke = (Caterpie)poke;
                Console.WriteLine($"\nA wild, {rdmLevel} level Caterpie appeared!");
                return poke;
            }
        }

        // METHOD: get additional multiplier from ball type, berry type, throw type
        public static float throwBall()
        {
            float ballMultiplier, berryMultiplier, curveMultiplier;           
            do
            {
                // prompt for ball type, validate input, set multiplier (float)
                Console.WriteLine("What kind of ball are you using?\n1) Pokeball\n2) Greatball\n3) Ultraball:");
                string ballType = Console.ReadLine();
                if (ballType == "1")
                {
                    ballMultiplier = 1.0f;  // set multiplier as float
                    break;
                }
                else if (ballType == "2")
                {
                    ballMultiplier = 1.5f;
                    break;
                }
                else if (ballType == "3")
                {
                    ballMultiplier = 2.0f;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter '1' (Pokeball), '2' (Greatball), or '3' (Ultraball):");
                }
            } while (true);  // loop till valid ball type
            
            do {
                // prompt for berry type, validate input, set multiplier (float)
                Console.WriteLine("Which berry would you like to use?\n1) None\n2) Razzberry\n3) SilverPinapberry\n4) GoldenRazzberry");
                string berryType = Console.ReadLine();
                if(berryType == "1")
                {
                    berryMultiplier = 1.0f;
                    break;
                }
                else if(berryType == "2")
                {
                    berryMultiplier = 1.5f;
                    break;
                }
                else if(berryType == "3")
                {
                    berryMultiplier = 2.0f;
                    break;
                }
                else if(berryType == "4")
                {
                    berryMultiplier = 2.5f;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter '1' for none, '2' for Razzberry, '3' for SilverPinapberry, or '4' for GoldenRazzberry.");
                    berryType = Console.ReadLine();
                }
            } while (true);  // loop till valid ball type

            // prompt for curveball or no curveball, validate input, set multiplier (float)
            Console.WriteLine("Throw a curveball? (y/n)");
            string throwType = Console.ReadLine();
            if (throwType == "y" || throwType == "Y")
            {
                curveMultiplier = 1.7f;
            }
            else if (throwType == "n" || throwType == "N")
            {
                curveMultiplier = 1.0f;
            }
            else
            {
                curveMultiplier = 1.0f;
                Console.WriteLine("Enter 'y' to throw a curveball or 'n' to throw straight.");
                throwType = Console.ReadLine();
            }

            // return total multiplier from ball type, berry type, and throw type
            return ballMultiplier * berryMultiplier * curveMultiplier;
        }

        // METHOD: calculate catch probability
        public static double calcProb(Pokemon newPoke)
        {
            // multipliers & luck factor
            double cpm = 0.49985844;           // base catch probability multiplier
            double throwMultis = throwBall();  // ball*berry*curve multiplier

            // catchProb = (1 - (1 - (BCR / (2 * CPM))))^addMult
            double catchProb = Math.Pow(1 - (1 - (newPoke.getBaseCatchRate() / (2 * cpm))), throwMultis);
            return catchProb;
        }

        // MAIN: game UI
        static void Main(string[] args)
        {
            Pokedex myDex = new Pokedex();  // create pokedex obj

            Console.WriteLine("Welcome to Pokemon GOnsole!");
            // loop throwBall() till pokemon caught
            do
            {               
                Pokemon currPoke = pokeSpawn();        // spawn a new pokemon
                double currProb = calcProb(currPoke);  // calculate catch probability
                double luck = rand.NextDouble();       // random [0,1) to compare to catchProb
                do
                {
                    // compare luck to catchProb
                    if (luck >= currProb)
                    {
                        if(currPoke is Bulbasaur)
                        {
                            currPoke = (Bulbasaur)currPoke;  // downcast parent to child
                            myDex.addToDex(currPoke);        // add polymorphed obj to List
                            currPoke.ToString();             // display attributes
                            break;
                        }
                        else if(currPoke is Charmander)
                        {
                            currPoke = (Charmander)currPoke;
                            myDex.addToDex(currPoke);
                            currPoke.ToString();
                            break;
                        }
                        else
                        {
                            currPoke = (Caterpie)currPoke;
                            myDex.addToDex(currPoke);
                            currPoke.ToString();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quick, try again!");
                        throwBall();
                    }
                } while(true);
                
                // prompt to continue playing
                Console.WriteLine("\nWould you like to look for more pokemon? (y/n)");
                string cont = Console.ReadLine();

                if (cont == "n" || cont == "N")
                {
                    Console.WriteLine("Time to go home and not eat the weakest catch!");
                    Console.WriteLine(myDex.ToString());
                    break;
                }
                else if (cont == "y" || cont == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Enter 'y' to catch another pokemon or 'n' to stop.");
                }

            } while(true);            
        }
    }
}
