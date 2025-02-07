using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/find-the-number-of-distinct-colors-among-the-balls/

    public class FindTheNumberOfDistinctColorsAmongTheBalls
    {
        public static int[] QueryResults(int limit, int[][] queries)
        {
            List<int> answer = new List<int>(queries.Length);
            Dictionary<int, int> usedColors = new Dictionary<int, int>();
            Dictionary<int, int> usedBalls = new Dictionary<int, int>();

            for (int i = 0; i < queries.Length; ++i)
            {
                if (usedBalls.ContainsKey(queries[i][0]))
                {
                    int oldColor = usedBalls[queries[i][0]];
                    usedColors[oldColor] = usedColors[oldColor] - 1;
                    if (usedColors[oldColor] == 0)
                    {
                        usedColors.Remove(oldColor);
                    }
                }

                usedBalls[queries[i][0]] = queries[i][1];

                usedColors.TryGetValue(queries[i][1], out int value);
                usedColors[queries[i][1]] = value + 1;

                answer.Add(usedColors.Count);
            }

            return answer.ToArray();
        }
    }
}
