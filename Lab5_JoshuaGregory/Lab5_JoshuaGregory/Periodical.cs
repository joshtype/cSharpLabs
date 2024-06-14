// Joshua Gregory; June 2024
// SimpleLibrary child class
// Abstract classes & polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_JoshuaGregory
{
    internal class Periodical : Item
    {
        // child attributes (inherits title)
        private int issueNum;

        // constructors
        public Periodical()
        {
            this.setTitle("");
            this.issueNum = 0;
        }
        public Periodical(string newTitle, int newIssueNum)
        {
            this.setTitle(newTitle);
            this.issueNum = newIssueNum;
        }

        // getter & setter
        public int getIssueNum() { return this.issueNum; }
        public void setIssueNum(int newIssueNum) { this.issueNum = newIssueNum; }


        // override getListing()
        public override string getListing()
        {
            return ($"\nPeriodical title: {this.getTitle()}\nIssue number: {this.issueNum}");
        }
    }
}
