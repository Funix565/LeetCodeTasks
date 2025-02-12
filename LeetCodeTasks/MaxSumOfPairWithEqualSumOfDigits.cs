using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits/

    public class MaxSumOfPairWithEqualSumOfDigits
    {
        public int MaximumSum(int[] nums)
        {
            int answer = -1;

            // Store digit sums and numbers with that digit sum. Numbers are sorted, max first. PQ because SortedSet is unique.
            Dictionary<int, PriorityQueue<int, int>> digitSumToNumbers = new Dictionary<int, PriorityQueue<int, int>>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int digitSum = SumDigits(nums[i]);

                if (!digitSumToNumbers.TryGetValue(digitSum, out _))
                {
                    // Create PQ: on dequeue, the item with the highest priority value is removed
                    digitSumToNumbers[digitSum] = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) =>
                    {
                        if ((x - y) > 0)
                        {
                            return -1;
                        }
                        else if ((x - y) < 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }));
                }

                digitSumToNumbers[digitSum].Enqueue(nums[i], nums[i]);
            }

            // Check every group and add two max values from PQ, accumulate answer.
            foreach (var pq in digitSumToNumbers.Values)
            {
                int i = pq.Dequeue();
                if (pq.TryDequeue(out int j, out int priority))
                {
                    answer = Math.Max(answer, i + j);
                }
            }

            return answer;
        }

        private static int SumDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int digit = number % 10;
                result = result + digit;
                number = number / 10;
            }

            return result;
        }
    }
}
