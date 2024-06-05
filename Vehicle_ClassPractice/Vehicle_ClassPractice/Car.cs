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
    internal class Car : Vehicle
    {
        // child attributes (plus parent attributes)
        private int numDoors;
        private bool isConvertible;

        // constructors
        public Car() : base()
        {
            this.numDoors = 0;
            this.isConvertible = false;
        }
        public Car(string newMakeModel, int newYear, int numDoors, bool isConvertible) : base(newMakeModel, newYear)
        {
            this.numDoors = numDoors;
            this.isConvertible = isConvertible;
        }

        // getters & setters
        public int getNumDoors() { return this.numDoors; }
        public bool getIsConvertible() { return this.isConvertible; }
        public void setNumDoors(int newNumDoors) { this.numDoors = newNumDoors; }
        public void setIsConvertible(bool newIsConvertible) { this.isConvertible = newIsConvertible; }

        // override ToString
        public override string ToString()
        {
            return "\nCar: " + getYear() + " " + getMakeModel() + " with " + getNumDoors() + " doors (Convertible: " + getIsConvertible() + ").";
        }
    }
}
