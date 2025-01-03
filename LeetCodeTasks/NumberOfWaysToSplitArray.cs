using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/number-of-ways-to-split-array/

    public class NumberOfWaysToSplitArray
    {
        public static int Solve(int[] nums)
        {
            int numberOfValidSplits = 0;

            // preparation
            long arraySum = 0;
            foreach (int num in nums)
            {
                arraySum += num;
            }

            // solution
            long indexSum = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                indexSum = indexSum + nums[i];

                if (indexSum >= arraySum - indexSum)
                {
                    ++numberOfValidSplits;
                }
            }

            return numberOfValidSplits;
        }
    }
}
