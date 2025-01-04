using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/unique-length-3-palindromic-subsequences/

    public class UniqueLength3PalindromicSubsequences
    {
        public static int Solve(string s)
        {
            // array to track letters and their indexes in initial string
            int[][] lettersIndexes = new int[26][];
            for (int i = 0; i < 26; ++i)
            {
                lettersIndexes[i] = [-1, -1];
            }

            // check every letter and save its indexes [first_occurrence][last_occurrence]
            for (int i = 0; i < s.Length; ++i)
            {
                int index = s[i] - 'a';

                if (lettersIndexes[index][0] == -1)
                {
                    lettersIndexes[index][0] = i;
                    lettersIndexes[index][1] = i;
                }
                else
                {
                    lettersIndexes[index][1] = i;
                }
            }

            // solution
            HashSet<string> palindromes = new HashSet<string>();
            for (int i = 0; i < s.Length; ++i)
            {
                int index = s[i] - 'a';
                if ((lettersIndexes[index][1] - lettersIndexes[index][0] - 1) != 0)
                {
                    for (int j = lettersIndexes[index][0]; j < lettersIndexes[index][1] - 1; ++j)
                    {
                        char[] palindrome = [s[i], s[j + 1], s[i]];
                        palindromes.Add(new string(palindrome));
                    }

                    lettersIndexes[index][0] = lettersIndexes[index][1];
                }
            }

            return palindromes.Count;
        }
    }
}
