using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscPractice
{
    internal abstract class Mammal
    {
        // Tree 1: Mammal -> Dog -> Lab, Poodle

        private double weight;
        private string color;

        public void setWeight(double w) { weight = w; }
        public double getWeight() { return weight; }
        public void setColor(string c) { color = c; }
        public string getColor() { return color; }

        // virtual = override
        public virtual string speak()
        {
            return "noise";
        }
        public virtual string ToString()
        {
            return $"{this.getColor()} mammal weighs {this.getWeight()} lbs";
        }
    }
}
