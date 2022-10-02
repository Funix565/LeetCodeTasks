using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/

    public class SquaresOfASortedArray
    {
        public static int[] Solve(int[] nums)
        {
            // Square each element and sort the new array
            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);

            return nums;
        }
    }
}
