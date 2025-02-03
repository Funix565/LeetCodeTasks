namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/

    public class CheckIfArrayIsSortedAndRotated
    {
        public bool Check(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i + 1] < nums[i])
                {
                    if (nums[i + 1] > nums[0])
                    {
                        return false;
                    }

                    for (int j = i + 1; j < nums.Length - 1; ++j)
                    {
                        if (nums[j + 1] < nums[j] || nums[j + 1] > nums[0])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
