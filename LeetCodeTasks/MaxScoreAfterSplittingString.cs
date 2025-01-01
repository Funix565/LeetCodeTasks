namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/maximum-score-after-splitting-a-string

    // Accepted first try.
    // Approach: analyze all splits and find score for each. Return max possible score.

    public class MaxScoreAfterSplittingString
    {
        public static int Solve(string s)
        {
            int maxScore = 0;
            int splitIndex = 1;

            while (splitIndex < s.Length)
            {
                var left = s.Substring(0, splitIndex);
                var right = s.Substring(splitIndex);

                var leftScore = left.Split('0').Length - 1;
                var rightScore = right.Split('1').Length - 1;

                if (leftScore + rightScore > maxScore)
                {
                    maxScore = leftScore + rightScore;
                }

                ++splitIndex;
            }

            return maxScore;
        }
    }
}
