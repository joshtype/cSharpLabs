// Joshua Gregory; June 2024
// RandNumGuess Spanish child
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_JoshuaGregory
{
    internal class Spanish : Language
    {
        // override Language abstract methods
        public override string makeGuess()
        {
            return " Adivina un numero [0,100]:";
        }
        public override string tooLow()
        {
            return "Demasiado bajo. Nueva conjetura:";
        }
        public override string tooHigh()
        {
            return "Demasiado alto. Nueva conjetura:";
        }
        public override string correct()
        {
            return "Correcto!";
        }
    }
}
