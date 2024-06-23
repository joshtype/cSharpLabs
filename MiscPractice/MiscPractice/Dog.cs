using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscPractice
{
    internal class Dog : Mammal  // Dog 'is' Mammal
    {
        
        // inherits weight, color, speak()

        public Dog() 
        {
            this.setWeight(1.0);
            this.setColor("default color");
        }

        public Dog(double w, string c)
        {
            this.setWeight(w);
            this.setColor(c);
        }

        // override speak()
        public override string speak()
        {
            return "bark!";
        }
        public override string ToString()
        {
            return $"{this.getColor()} dog weighs {this.getWeight()} lbs";
        }
    }
}
