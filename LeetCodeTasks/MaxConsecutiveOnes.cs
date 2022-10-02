using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/max-consecutive-ones/

    public class MaxConsecutiveOnes
    {
        public static int Solve(int[] nums)
        {
            // General count of 1s
            int maxOnes = 0;

            // Current window
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    current++;
                }
                
                // Case when we have the last iteration
                if (nums[i] == 0 || i == nums.Length - 1)
                {
                    maxOnes = Math.Max(current, maxOnes);
                    current = 0;
                }
            }

            return maxOnes;
        }
    }
}
