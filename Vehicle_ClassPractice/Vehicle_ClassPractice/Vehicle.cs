// Joshua Gregory - June 2024
// Vehicle_ClassPractice - C# Class Practice
// Parent class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_ClassPractice
{
    internal class Vehicle
    {
        // parent attributes to be inherited
        private string makeModel;
        private int year;

        // constructors
        public Vehicle()
        {
            this.makeModel = "N/A";
            this.year = 1;
        }
        public Vehicle(string newMkeModel, int newYear)
        {
            this.makeModel = newMkeModel;
            this.year = newYear;
        }

        // getters
        public string getMakeModel() { return this.makeModel; }
        public int getYear() { return this.year; }
        // setters
        public void setMakeModel(string m) { this.makeModel = m; }
        public void setYear(int y) { this.year = y; }

        // override ToString
        public override string ToString()
        {
            return "\nGeneric: " + year.ToString() + " " + getMakeModel();
        }
    }
}
