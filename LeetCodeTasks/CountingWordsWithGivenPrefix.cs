namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/counting-words-with-a-given-prefix/

    public class CountingWordsWithGivenPrefix
    {
        public static int Solve(string[] words, string pref)
        {
            int answer = 0;

            foreach (string word in words)
            {
                if (word.Length >= pref.Length && word.StartsWith(pref))
                {
                    ++answer;
                }
            }

            return answer;
        }
    }
}
