using System.Text;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/clear-digits/

    public class ClearDigits
    {
        public string Solve(string s)
        {
            StringBuilder answer = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsDigit(c) && answer.Length > 0)
                {
                    answer.Remove(answer.Length - 1, 1);
                }
                else
                {
                    answer.Append(c);
                }
            }

            return answer.ToString();
        }
    }
}
