using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractice
{
    internal interface IRecurMath
    {
       public virtual int addXY(int xIn, int yIn)
        {
            return xIn + yIn;
        }

        public virtual int subtractXY(int xIn, int yIn)
        {
            return xIn - yIn;
        }

        public virtual int keepAddingXY(int xIn, int yIn)
        {
            if(xIn == 0 || yIn == 0)
            {
                return 0;  // base case 0
            }
            else if (xIn == 1)
            {
                return yIn;  // base case 1
            }
            else if (yIn == 1)
            {
                return xIn;  // base case 2
            }
            else
            {
                return 1 + keepAddingXY(xIn + 1, yIn + 1);  // recursive case
            }
        }
    }
}
