using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Arrays : Collections
    {
        // inherits parent arrays & must override any parent abstract methods

        // Override of abstr parent:
        // Iterates flat int arr, turns negative values to 0
        public override int[] noNegatives(int[] intArr)
        {
            // iterating flat arr reqs 1-deep for/each loop = O(n)
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] < 0)
                {
                    intArr[i] = 0;
                }
            }
            return intArr;
        }

        // Override of abstr parent:
        // Iterates flat str arr, counts idxs with empty strings
        public override int numEmptyStr(string[] strArr)  // must override abstract parent method & declare body
        {
            int numEmpty = 0;
            foreach (string s in strArr)
            {
                if (s.Length == 0)
                {
                    numEmpty++;
                }
            }
            return numEmpty;
        }

        // Override of abstr parent:
        // Cecks if arr of any type is flat or 2d via params keyword.
        public override void iterArr(params object[] anyArr)
        {
            // if nonempty arr has rank 1, it's flat
            if (anyArr != null && anyArr.Rank == 1)
            {
                if (anyArr[0] is int)
                {
                    Console.WriteLine("It's a flat int array.");
                }
                else if (anyArr[0] is string)
                {
                    Console.WriteLine("It's a flat string array.");
                }
                else if (anyArr[0] is double)
                {
                    Console.WriteLine("It's a flat double array.");
                }
            }
            // if nonempty arr has rank 2, it's multi-dimensional (2d)
            if (anyArr != null && anyArr.Rank == 2)
            {
                Console.WriteLine("It's a 2d array.");
            }
        }

        // Override of abstr parent:
        // Method iterates 2d Collections arr, changes Collections obj to Arrays obj.
        // (Example of late-binding polymorphism, obj class is bound at runtime.)
        public override Collections[,] changetoArrays(Collections[,] cArr)
        {
            // 2d arr iteration reqs 2deep for loops = O(n2)
            // / GetLength(0) for [3,4] = 3 (rows), GetLegnth(1) for [3,4] = 4 (cols)
            for (int i = 0; i < cArr.GetLength(0); i++)  // outer = ith row
            {
                for (int j = 0; j < cArr.GetLength(1); j++)  // inner = jth col
                {
                    if(i%2 == 0)
                    {
                        // late-binding polymorphism (idx type unknown till runtime)
                        cArr[i, j] = (Arrays)cArr[i, j];  // obj in even idx casted to Arrays type 
                    }
                    else
                    {
                        // late-binding polymorphic (idx type unknown till runtime)
                        cArr[i, j] = new Arrays(); // replace obj with new Arrays obj (default attributes)

                        // cArr[i,j] = new Arrays(int[] n, string[] s, double[] d);  // valid if available
                    }
                }
            }

            return cArr;
        }
    }
}
