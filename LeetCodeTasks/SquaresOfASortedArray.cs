using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/squares-of-a-sorted-array/

    public class SquaresOfASortedArray
    {
        public static int[] Solve(int[] nums)
        {
            // Create the new result array.
            // Create an end-index for the result array.
            // Create two indexes -- begin, end -- for the initial array. Because they will have the highest squares
            // Top loop condition -- end-result index >= 0
            // Compare absolute values of the begin and end.
            // If nums[begin] < nums[end]:
            //      add square of the end element to the result
            //      decrement end-index
            //      decrement result array index
            // Else if nums[begin] >= nums[end]:
            //      add square of the begin element to the result
            //      decrement end-index
            //      decrement result array index

            int[] result = new int[nums.Length];
            var begin = 0;
            var end = nums.Length - 1;
            for (var endResult = result.Length - 1; endResult >= 0; --endResult)
            {
                if (Math.Abs(nums[begin]) < Math.Abs(nums[end]))
                {
                    result[endResult] = nums[end] * nums[end];
                    --end;
                }
                else
                {
                    result[endResult] = nums[begin] * nums[begin];
                    ++begin;
                }
            }

            return result;
        }
    }
}
