using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits/

    public class MaxSumOfPairWithEqualSumOfDigits
    {
        public int MaximumSum_PlaiArraysOnePass(int[] nums)
        {
            int answer = -1;

            int largestDigitSum = SumDigits(999999999);

            int[][] digitSumToNumbers = new int[largestDigitSum + 1][];

            for (int i = 0; i < nums.Length; ++i)
            {
                int digitSum = SumDigits(nums[i]);

                if (digitSumToNumbers[digitSum] == null)
                {
                    digitSumToNumbers[digitSum] = [-1, -1];
                }

                // If the current number is at least as large as one of the two stored values, consider updating
                if (nums[i] >= digitSumToNumbers[digitSum][1])
                {
                    // If it's larger than the first max, shift both values down
                    if (nums[i] > digitSumToNumbers[digitSum][0])
                    {
                        digitSumToNumbers[digitSum][1] = digitSumToNumbers[digitSum][0];
                        digitSumToNumbers[digitSum][0] = nums[i];
                    }
                    // Otherwise, update only the second max
                    else
                    {
                        digitSumToNumbers[digitSum][1] = nums[i];
                    }
                }

                // We can integrate the second loop logic directly in the main loop.
                // The intention is the same - calculate sum of a pair.
                // And also we operate the actual values immediately, without searching all array and skipping nulls.
                int[] pq = digitSumToNumbers[digitSum];

                if (pq != null && pq[1] != -1 && pq[0] != -1)
                {
                    int first = pq[0];
                    int second = pq[1];
                    answer = Math.Max(answer, first + second);
                }
            }

            //foreach (int[] pq in digitSumToNumbers)
            //{
            //    if (pq != null && pq[1] != -1 && pq[0] != -1)
            //    {
            //        int i = pq[0];
            //        int j = pq[1];
            //        answer = Math.Max(answer, i + j);
            //    }
            //}

            return answer;
        }

        public int MaximumSum_PlainArrays(int[] nums)
        {
            int answer = -1;

            int largestDigitSum = SumDigits(999999999);

            int[][] digitSumToNumbers = new int[largestDigitSum + 1][];

            for (int i = 0; i < nums.Length; ++i)
            {
                int digitSum = SumDigits(nums[i]);

                if (digitSumToNumbers[digitSum] == null)
                {
                    digitSumToNumbers[digitSum] = [-1, -1];
                }

                // If the current number is at least as large as one of the two stored values, consider updating
                if (nums[i] >= digitSumToNumbers[digitSum][1])
                {
                    // If it's larger than the first max, shift both values down
                    if (nums[i] > digitSumToNumbers[digitSum][0])
                    {
                        digitSumToNumbers[digitSum][1] = digitSumToNumbers[digitSum][0];
                        digitSumToNumbers[digitSum][0] = nums[i];
                    }
                    // Otherwise, update only the second max
                    else
                    {
                        digitSumToNumbers[digitSum][1] = nums[i];
                    }
                }
            }

            foreach (int[] pq in digitSumToNumbers)
            {
                if (pq != null && pq[1] != -1 && pq[0] != -1)
                {
                    int i = pq[0];
                    int j = pq[1];
                    answer = Math.Max(answer, i + j);
                }
            }

            return answer;
        }

        public static int MaximumSum_FrequencyArrayWithoutPriorityQueue(int[] nums)
        {
            int answer = -1;

            int largestDigitSum = SumDigits(999999999);

            int[][] digitSumToNumbers = new int[largestDigitSum + 1][];

            for (int i = 0; i < nums.Length; ++i)
            {
                int digitSum = SumDigits(nums[i]);

                if (digitSumToNumbers[digitSum] == null)
                {
                    digitSumToNumbers[digitSum] = [-1, -1];
                }

                // If the current number is at least as large as one of the two stored values, consider updating
                if (nums[i] >= digitSumToNumbers[digitSum][1])
                {
                    // If it's larger than the first max, shift both values down
                    if (nums[i] > digitSumToNumbers[digitSum][0])
                    {
                        digitSumToNumbers[digitSum][1] = digitSumToNumbers[digitSum][0];
                        digitSumToNumbers[digitSum][0] = nums[i];
                    }
                    // Otherwise, update only the second max
                    else
                    {
                        digitSumToNumbers[digitSum][1] = nums[i];
                    }
                }

                // Update the answer immediately after modifying the stored values, and avoid iterating over unused slots.
                int[] pq = digitSumToNumbers[digitSum];

                if (pq != null && pq[1] != -1 && pq[0] != -1)
                {
                    int first = pq[0];
                    int second = pq[1];
                    answer = Math.Max(answer, first + second);
                }
            }

            return answer;
        }

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
