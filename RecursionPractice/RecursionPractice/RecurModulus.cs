using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractice
{
    internal class RecurModulus : IRecurMath
    {
        private static int x, y;

        // constructor
        public RecurModulus() { }
        public RecurModulus(int initX, int initY)
        {
            initX = x;
            initY = y;
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int initX) { initX = x; }
        public void setY(int initY) { initY = y; }

        public int addXY(int initX, int initY)
        {
            return initX + initY;
        }

        public int modulusXY(int initX, int initY)
        {
            if (initX == 0 || initY == 0)
            {
                return 0;  // base case 0
            }
            else if (initX == 1)
            {
                return 0;  // base case 1
            }
            else if (initY == 1)
            {
                return 0;  // base case 2
            }
            else
            {
                return 1 + modulusXY(initX - 1, initY - 1);  // recursive case
            }
        }
    } 
}
