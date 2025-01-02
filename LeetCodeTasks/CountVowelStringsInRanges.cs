using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/count-vowel-strings-in-ranges/

    public class CountVowelStringsInRanges
    {
        public static int[] Solve(string[] words, int[][] queries)
        {
            HashSet<char> vowels = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            List<int> ans = new List<int>();

            foreach (int[] pair in queries)
            {
                int queryAnswer = 0;
                for (int i = pair[0]; i <= pair[1]; ++i)
                {
                    string word = words[i];
                    if (vowels.Contains(word[0]) && vowels.Contains(word[word.Length - 1]))
                    {
                        ++queryAnswer;
                    }
                }
                ans.Add(queryAnswer);
            }

            return ans.ToArray();
        }
    }
}
