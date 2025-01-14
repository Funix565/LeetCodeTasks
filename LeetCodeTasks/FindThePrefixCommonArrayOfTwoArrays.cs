using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/

    public class FindThePrefixCommonArrayOfTwoArrays
    {
        public static int[] Solve(int[] A, int[] B)
        {
            List<int> answer = new List<int>();

            HashSet<int> visitedElements = new HashSet<int>(A.Length);

            int count = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] == B[i])
                {
                    ++count;
                }

                if (visitedElements.Contains(A[i]))
                {
                    ++count;
                }
                
                if (visitedElements.Contains(B[i]))
                {
                    ++count;
                }

                answer.Add(count);

                visitedElements.Add(A[i]);
                visitedElements.Add(B[i]);
            }

            return answer.ToArray();
        }
    }
}
