using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal abstract class Collections
    {
        // flat (one-dimensional) arrays, no capacity declared
        private int[] intArr;
        private double[] dblArr;
        private string[] strArr;
        private Collections[] cArr;  // stores Collections objs

        // multi-dimensional (2d) arrays, no capacity declared
        private int[,] ints2D;
        private double[,] dbl2D;
        private string str2D;
        private Collections[,] c2D;

        // Method iterates flat int arr, turns negative values to 0
        public abstract int[] noNegatives(int[] intArr);

        // Method iterates flat str arr, counts idxs with empty strings
        public abstract int numEmptyStr(string[] strArr);

        // Method iterates 2d Collections arr, changes Collections obj to Arrays obj.
        // Example of late-binding polymorphism, obj class is bound at runtime.
        public abstract Collections[,] changetoArrays(Collections[,] cArr);

        // Method takes arr of any type and checks if its flat or 2d via params keyword
        public abstract void iterArr(params object[] anyArr);      
    }
}
