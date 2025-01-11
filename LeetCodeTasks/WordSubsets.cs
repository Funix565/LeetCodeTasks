using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/word-subsets/

    public class WordSubsets
    {
        public static IList<string> Solve(string[] words1, string[] words2)
        {
            // prepare
            int[] countPerCharGlobal = new int[26];
            foreach (string word in words2)
            {
                int[] countPerCharWord = new int[26];
                foreach (char c in word)
                {
                    int index = c - 'a';
                    countPerCharWord[index] = countPerCharWord[index] + 1;
                }

                for (int i = 0; i < 26; ++i)
                {
                    countPerCharGlobal[i] = Math.Max(countPerCharGlobal[i], countPerCharWord[i]);
                }
            }

            List<string> answer = new List<string>();

            // solution
            foreach (string word in words1)
            {
                bool isValid = false;
                for (int i = 0; i < countPerCharGlobal.Length; ++i)
                {
                    if (countPerCharGlobal[i] != 0)
                    {
                        if (CountCharOccurrencesInString(word, (char)(i + 'a')) < countPerCharGlobal[i])
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                }

                if (isValid)
                {
                    answer.Add(word);
                }
            }

            return answer;
        }

        private static int CountCharOccurrencesInString(string str, char character)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == character)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
