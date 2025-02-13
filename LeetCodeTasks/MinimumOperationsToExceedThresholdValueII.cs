using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-ii/

    public class MinimumOperationsToExceedThresholdValueII
    {
        public static int MinOperations(int[] nums, int k)
        {
            int answer = 0;
            PriorityQueue<long, long> pq = new PriorityQueue<long, long>();
            foreach (int element in nums)
            {
                pq.Enqueue(element, element);
            }

            long x = pq.Peek();
            while (pq.Count >= 2 && x < k)
            {
                ++answer;

                x = pq.Dequeue();
                long y = pq.Dequeue();

                long number = Math.Min(x, y) * 2 + Math.Max(x, y);

                pq.Enqueue(number, number);

                x = pq.Peek();
            }

            return answer;
        }
    }
}
