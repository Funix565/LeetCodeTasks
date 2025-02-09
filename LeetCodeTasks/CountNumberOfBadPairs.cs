using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/count-number-of-bad-pairs/

    public class CountNumberOfBadPairs
    {
        public long CountBadPairs(int[] nums)
        {
            long answer = 0;

            // Get the total number of unique pairs. Simplified Combination formula
            long allPairs = nums.LongLength * (nums.LongLength - 1) / 2;

            Dictionary<int, int> diffs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int diff = nums[i] - i;
                diffs.TryGetValue(diff, out int value);
                diffs[diff] = value + 1;
            }

            long goodPairs = 0;
            foreach (long value in diffs.Values)
            {
                goodPairs = goodPairs + (value * (value - 1) / 2);
            }

            answer = allPairs - goodPairs;

            return answer;
        }
    }
}
