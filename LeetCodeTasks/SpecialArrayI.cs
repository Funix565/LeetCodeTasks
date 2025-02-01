namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/special-array-i/

    public class SpecialArrayI
    {
        public bool Solve(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            for (int i = 0, j = 1; j < nums.Length; ++i, ++j)
            {
                if (((nums[i] + nums[j]) & 1) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
