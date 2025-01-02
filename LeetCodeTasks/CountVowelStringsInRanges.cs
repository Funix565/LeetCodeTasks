using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/count-vowel-strings-in-ranges/

    public class CountVowelStringsInRanges
    {
        public static int[] Solve(string[] words, int[][] queries)
        {
            HashSet<char> vowels = new HashSet<char>(['a', 'e', 'i', 'o', 'u']);
            List<int> ans = new List<int>();
            List<int> numberOfStrings = new List<int>(words.Length);

            // preparation
            string firstWord = words[0];
            if (vowels.Contains(firstWord[0]) && vowels.Contains(firstWord[firstWord.Length - 1]))
            {
                numberOfStrings.Add(1);
            }
            else
            {
                numberOfStrings.Add(0);
            }

            for (int i = 1; i < words.Length; ++i)
            {
                string word = words[i];
                if (vowels.Contains(word[0]) && vowels.Contains(word[word.Length - 1]))
                {
                    var res = numberOfStrings[i - 1];
                    numberOfStrings.Add(res + 1);
                }
                else
                {
                    var res = numberOfStrings[i - 1];
                    numberOfStrings.Add(res);
                }
            }

            // solution
            foreach (int[] query in queries)
            {
                if (query[0] == 0)
                {
                    var exist = numberOfStrings[query[1]];
                    ans.Add(exist);
                }
                else
                {
                    var leftResult = numberOfStrings[query[0] - 1];
                    var rightResult = numberOfStrings[query[1]];

                    ans.Add(rightResult - leftResult);
                }
            }

            return ans.ToArray();
        }
    }
}
