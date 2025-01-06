using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/

    public class MinNumberOfOperationsToMoveAllBallsToEachBox
    {
        public static int[] Solve(string boxes)
        {
            int[] answer = new int[boxes.Length];

            // preparation
            List<int> whereIsBallIndexes = new List<int>();

            for (int i = 0; i < boxes.Length; ++i)
            {
                if (boxes[i] == '1')
                {
                    whereIsBallIndexes.Add(i);
                }
            }

            // solution
            for (int i = 0; i < boxes.Length; ++i)
            {
                int operations = 0;
                foreach (int num in whereIsBallIndexes)
                {
                    operations = operations + Math.Abs(num - i);
                }

                answer[i] = operations;
            }

            return answer;
        }
    }
}
