// Joshua Gregory; June 2024
// Store Inventory -> StockItem Class File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2_JoshuaGregory
{
    internal class StockItem
    {
        // PARENT ATTRIBUTES
        private string descr;
        private double price;
        private int qty;
        private int id;
        private static int currID = 0;  // increments for each new obj 


        // DEFAULT CONSTRUCTOR
        public StockItem()
        {
            this.descr = "N/A";
            this.price = 0.0;
            this.qty = 0;
            this.id = currID;        // set to current id
            currID++;                // increment tempID
        }
        // ARGUMENTED CONSTRUCTOR
        public StockItem(string newDescr, double newPrice, int newQty)
        {
            this.descr = newDescr;
            this.price = newPrice;
            this.qty = newQty;
            this.id = currID;        // set to current id
            currID++;                // increment tempID
        }

        // GETTERS
        public string GetDescr() { return this.descr; }
        public int GetId() { return this.id; }
        public double GetPrice() { return this.price; }
        public int GetQty() { return this.qty; }

        // SETTERS
        public void LowerQty(int n)
        {
            this.qty -= n;
        }
        public void SetPrice(double p)
        {
           this.price = p;
        }
        public void RaiseQty(int n)
        {
            this.qty += n;
        }

        // OVERRIDE ToString()
        public override string ToString()
        {
            return "Item number " + this.id + ": " + this.descr + ". Price: $" + this.price + ". Inventory: " + this.qty;
        }


    }
}
