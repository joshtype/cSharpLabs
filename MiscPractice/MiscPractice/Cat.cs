using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscPractice
{
    internal class Cat : Mammal
    {
        // inherits weight, color, speak()

        public Cat()
        {
            this.setWeight(1.0);
            this.setColor("default color");
        }

        public Cat(double w, string c)
        {
            this.setWeight(w);
            this.setColor(c);
        }

        // override speak() & ToString()
        public override string speak()
        {
            return "meow!";
        }
        public override string ToString()
        {
            return $"{this.getColor()} cat weighs {this.getWeight()} lbs";
        }

    }
}
