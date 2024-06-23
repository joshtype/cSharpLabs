// Joshua Gregory; June 2024
// Pokemon Go; Caterpie child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_JoshuaGregory
{
    internal class Caterpie : Pokemon
    {
        // Caterpie constructor
        public Caterpie(int initLevel)
        {
            // type = Caterpie, level = random, bcr = 10%
            Pokemon poke = new Pokemon("Caterpie", initLevel, .1);
        }

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }
    }
}
