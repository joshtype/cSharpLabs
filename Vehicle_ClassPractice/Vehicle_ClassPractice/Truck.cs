// Joshua Gregory - June 2024
// Vehicle_ClassPractice - C# Class Practice
// Child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_ClassPractice
{
    internal class Truck : Vehicle
    {
        // child attributes (plus parent attributes)
        private double bedLen;
        private bool is4x4;

        // constructors
        public Truck() : base()
        {
            this.bedLen = 0.0;
            this.is4x4 = false;
        }
        public Truck(string newMakeModel, int newYear, double newBedLen, bool newIs4x4) : base(newMakeModel, newYear)
        {
            this.bedLen = newBedLen;
            this.is4x4 = newIs4x4;
        }

        // getters & setters
        public double getBedLen() { return this.bedLen; }
        public bool getIs4x4() { return this.is4x4; }
        public void setBedLen(double newBedLen) { this.bedLen = newBedLen; }
        public void setIs4x4(bool newIs4x4) { this.is4x4 = newIs4x4; }

        // override ToString
        public override string ToString()
        {
            return "\nTruck: " + getYear() + " " + getMakeModel() + " with " + getBedLen() + "ft bed (4x4: " + getIs4x4() + ").";
        }
    }
}
