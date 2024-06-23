// Joshua Gregory; June 2024
// PokemonGOnsole Pokedex class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_JoshuaGregory
{
    internal class Pokedex
    {
        private List<Pokemon> myPokedex = new List<Pokemon>();  // Pokemon objs

        // add pokemon to pokedex
        public void addToDex(Pokemon newPokemon)
        {
            myPokedex.Add(newPokemon);
        }

        // ToString override
        public override string ToString()
        {
            if (myPokedex.Count <= 0)
            {
                return "Your Pokedex is empty!";
            }
            else
            {
                Console.WriteLine("\nPokedex contents:");
                foreach (Pokemon p in myPokedex)
                {
                    if(p is Bulbasaur)
                    {

                       Console.WriteLine($"Bulbasaur: {p.ToString()}");
                    }
                    else if(p is Charmander)
                    {
                        Console.WriteLine($"Charmander: {p.ToString()}");
                    }
                    else if(p is Caterpie)
                    {
                        Console.WriteLine($"Caterpie: {p.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"Unknown Pokemon: {p.ToString()}");
                    }
                }
            }
            return "";
        }
    }
}
