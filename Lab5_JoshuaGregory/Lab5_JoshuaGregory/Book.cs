// Joshua Gregory; June 2024
// SimpleLibrary child class
// Abstract classes & polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_JoshuaGregory
{
    internal class Book : Item
    {
        // child attributes (inherits title)
        private string isbnNum;  // (max int32 = 10 digits)
        private string author;

        // constructors
        public Book()
        {
            this.setTitle("");
            this.isbnNum = "";
            this.author = "";
        }
        public Book(string newTitle, string newISBN, string newAuthor)
        {
            this.setTitle(newTitle);
            this.isbnNum = newISBN;
            this.author = newAuthor;
        }

        // getters & setters
        public string getISBN() { return this.isbnNum; }
        public string getAuthor() { return this.author; }
        public void setISBN(string newISBN) { this.isbnNum = newISBN; }
        public void setAuthor(string newAuthor) { this.author = newAuthor; }

        // override getListing()
        public override string getListing()
        {
            return ($"\nBook title: {this.getTitle()}\nAuthor: {this.author}\nISBN: {this.isbnNum}");
        }
    }
}
