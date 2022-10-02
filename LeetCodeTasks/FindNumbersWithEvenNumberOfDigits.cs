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
            for (var i = 0; i < nums.Length; ++i)
            {
                // Convert a number to a string to find its length and therefore the nuber of digits
                var digits = nums[i].ToString().Length;

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
