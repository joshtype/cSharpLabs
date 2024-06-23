// Joshua Gregory; June 2024
// Money Dispenser; Coins Class
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_JoshuaGregory
{
    internal class Coins
    {
        // class attributes
        private int quantityOnHand;
        private float denomination;
        private float weight;

        // constructors
        public Coins()
        {
           quantityOnHand = 0;
           denomination = 0.0f;  // f = float
           weight = 0.0f;
        }
        public Coins(float newDenom, float newWeight)
        {
            this.quantityOnHand = 0;  // default = 0, set via increase/decreaseQuantity()
            this.denomination = newDenom;
            this.weight = newWeight;
        }

        // getters & setters
        public int getQuantityOnHand() { return this.quantityOnHand; }
        public float getDenomination() { return this.denomination; }
        public float getWeight() { return this.weight; }
        public void setQuantityOnHand(int newQuantity) { this.quantityOnHand = newQuantity; }
        public void setDenomination(float newDenom) { this.denomination = newDenom; }
        public void setWeight(float newWeight) { this.weight = newWeight; }

        // class methods
        public float getTotalWeight()
        {
           return this.quantityOnHand * this.weight;
        }
        public float getTotalValue()
        {
           return this.quantityOnHand * this.denomination;
        }
        public void increaseQuantity(int q)
        {
            this.quantityOnHand += q; 
        }
        public void decreaseQuantity(int q)
        {
            this.quantityOnHand -= q;
        }
        public string printPretty(float amount)
        {
            return ("$" + amount.ToString("F2"));
        }

        // override ToString
        public override string ToString()
        {
            return (printPretty(this.getTotalValue()) + " in " + this.denomination + " coins.");
        }
    }
}
