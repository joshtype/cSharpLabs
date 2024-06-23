// Joshua Gregory; June 2024
// RandNumGuess Language abstract parent
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_JoshuaGregory
{
    abstract class Language
    {
        // abstract methods to be overridden by derived classes
        public abstract string makeGuess();
        public abstract string tooLow();
        public abstract string tooHigh();
        public abstract string correct();
    }
}
