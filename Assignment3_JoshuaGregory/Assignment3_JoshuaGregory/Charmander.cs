// Joshua Gregory; June 2024
// Pokemon Go; Charmander child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_JoshuaGregory
{
    internal class Charmander : Pokemon
    {
        // Charmander constructor
        public Charmander(int initLevel)
        {
            // type = Charmander, level = random, bcr = 20%
            Pokemon poke = new Pokemon("Charmander", initLevel, .2);
        }

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }
    }
}
