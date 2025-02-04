using System;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/maximum-ascending-subarray-sum/

    public class MaximumAscendingSubarraySum
    {
        public int MaxAscendingSum(int[] nums)
        {
            int answer = nums[0];
            int sum = nums[0];
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i] < nums[i + 1])
                {
                    sum += nums[i + 1];
                }
                else
                {
                    answer = Math.Max(answer, sum);
                    sum = nums[i + 1];
                }
            }

            return Math.Max(answer, sum);
        }
    }
}
