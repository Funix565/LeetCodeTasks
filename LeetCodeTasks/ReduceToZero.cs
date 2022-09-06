using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

    public class ReduceToZero
    {
        public static int Solve(int num)
        {
            int steps = 0;
            while (num > 0)
            {
                // if the current number is even, you have to divide it by 2
                //if (num % 2 == 0)
                if ((num & 1) == 0)
                {
                    //num /= 2;
                    num >>= 1;
                }
                // otherwise, you have to subtract 1 from it
                else
                {
                    num -= 1;
                }

                ++steps;
            }

            return steps;
        }
    }
}
