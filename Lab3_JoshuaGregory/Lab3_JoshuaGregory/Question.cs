// Joshua Gregory; June 2024
// Quiz Maker -> Question Class File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_JoshuaGregory
{
    internal class Question
    {
        // class attributes
        private string text;  // question text
        private string ansr;  // question answer
        private int diff;     // 1 (easy) - 3 (hard)

        // no-arg constructor (set via get/set)
        public Question()
        {
            text = "N/A";
            ansr = "N/A";
            diff = 0;
        }
        // parameterized constructor (set via args)
        public Question(string initText, string initAnsr, int initDiff)
        {
            this.text = initText;
            this.ansr = initAnsr;
            this.diff = initDiff;
        }

        // getters & setters
        public string getText() { return this.text; }
        public string getAnsr() { return this.ansr; }
        public int getDiff() { return this.diff; }
        public void setText(string newText) { this.text = newText; }
        public void setAnsr(string newAnsr) { this.ansr = newAnsr; }
        public void setDiff(int newDiff) { this.diff = newDiff; }

        
    }
}
