using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/running-sum-of-1d-array/

    public class RunningSumOf1dArray
    {
        // Approach 2: Using Input Array for Output
        public static int[] Solve(int[] nums)
        {
            for (int i = 1; i < nums.Length; ++i)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
