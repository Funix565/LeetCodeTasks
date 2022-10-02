using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/

    public class FindNumbersWithEvenNumberOfDigits
    {
        public static int Solve(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                // Find the number of digits with / operator
                int digits = 1;
                while (nums[i] / 10 > 0)
                {
                    nums[i] = nums[i] / 10;
                    ++digits;
                }

                // The last bit of an even number is 0
                if ((digits & 1) == 0)
                {
                    ++answer;
                }
            }

            return answer;
        }
    }
}
