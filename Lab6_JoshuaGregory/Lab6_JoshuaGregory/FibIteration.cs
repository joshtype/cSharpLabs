// Joshua Gregory; June 2024
// Iterative FindFib implementation
// Interfacing & Implementing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_JoshuaGregory
{
    internal class FibIteration : FindFib
    {
        public int calculateFib(int n)
        {
            // F(n) = F(n-1) + F(n-2)

            // base case (n = 0, 1, 2)
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int fn = 0;
                int fn1 = 1;
                int fn2 = 1;
                for (int i = 3; i <= n; i++)
                {
                    fn = fn1 + fn2;
                    fn1 = fn2;
                    fn2 = fn;
                }
                return fn;
            }
        }
    }
}
