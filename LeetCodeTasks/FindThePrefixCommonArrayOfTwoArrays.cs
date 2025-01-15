using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/

    public class FindThePrefixCommonArrayOfTwoArrays
    {
        public static int[] Solve(int[] A, int[] B)
        {
            List<int> answer = new List<int>();

            int[] visitedElements = new int[A.Length + 1];

            int count = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                ++visitedElements[A[i]];
                ++visitedElements[B[i]];

                if (A[i] != B[i])
                {
                    if (visitedElements[A[i]] == 2)
                    {
                        ++count;
                    }

                    if (visitedElements[B[i]] == 2)
                    {
                        ++count;
                    }
                }
                else
                {
                    ++count;
                }

                answer.Add(count);
            }

            return answer.ToArray();
        }
    }
}
