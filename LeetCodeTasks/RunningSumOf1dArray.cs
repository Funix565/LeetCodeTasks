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
        // Approach 1: Using Separate Space
        public static int[] Solve(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }
    }
}
