// Joshua Gregory; June 2024
// Money Dispenser -> Notes Class File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_JoshuaGregory
{
    internal class Notes
    {
        // class attributes
        private int quantityOnHand;
        private int denomination;

        // constructors
        public Notes()
        {
            quantityOnHand = 0;  // both set via setters
            denomination = 0;
        }
        public Notes(int newDenom)
        {
            this.quantityOnHand = 0;  // set via setter
            this.denomination = newDenom;
        }

        // getters & setters
        public int getQuantityOnHand() { return this.quantityOnHand; }
        public int getDenomination() { return this.denomination; }
        public void setQuantityOnHand(int newQuantity) { this.quantityOnHand = newQuantity; }
        public void setDenomination(int newDenom) { this.denomination = newDenom; }

        // class methods
        public int getTotalValue()
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
            return (printPretty(this.getTotalValue()) + " in " + this.denomination + " notes.");
        }

    }
}
