// Joshua Gregory; June 2024
// Pokemon Go; Bulbasaur child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_JoshuaGregory
{
    internal class Bulbasaur : Pokemon
    {
        // Bulbasaur constructor (call parent)
        public Bulbasaur(string initType, int initLevel)
        {
            // type = Bulbasaur, level = random, bcr = 20%
            Pokemon poke = new Bulbasaur("Bulbasaur", initLevel, .2);
        }

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }

    }
}
