using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/minimum-length-of-string-after-operations/

    public class MinimumLengthOfStringAfterOperations
    {
        public static int SolveAfterHints(string s)
        {
            int answerLength = s.Length;

            int[] lettersFreq = new int[26];

            // preparation
            for (int i = 0; i < s.Length; ++i)
            {
                int index = s[i] - 'a';
                lettersFreq[index] = lettersFreq[index] + 1;
            }

            // solution
            for (int i = 0; i < lettersFreq.Length; ++i)
            {
                if (lettersFreq[i] > 0)
                {
                    if (lettersFreq[i] % 2 == 1)
                    {
                        answerLength = answerLength - (lettersFreq[i] - 1);
                    }
                    else
                    {
                        answerLength = answerLength - (lettersFreq[i] - 2);
                    }
                }
            }

            return answerLength;
        }

        public static int Solve(string s)
        {
            int answerLength = s.Length;

            char[] chars = s.ToCharArray();

            LinkedList<int>[] letterIndexes = new LinkedList<int>[26];
            for (int i = 0; i < letterIndexes.Length; ++i)
            {
                letterIndexes[i] = new LinkedList<int>();
            }

            // preparation
            for (int i = 0; i < chars.Length; ++i)
            {
                int index = chars[i] - 'a';
                letterIndexes[index].AddLast(i);
            }

            // solution
            for (int i = 1; i < chars.Length - 1; ++i)
            {
                if (chars[i] != '-')
                {
                    int index = chars[i] - 'a';
                    var node = letterIndexes[index].Find(i);

                    if (node.Previous != null && node.Next != null)
                    {
                        chars[node.Previous.Value] = '-';
                        chars[node.Next.Value] = '-';

                        letterIndexes[index].Remove(node.Previous);
                        letterIndexes[index].Remove(node.Next);

                        answerLength = answerLength - 2;
                    }
                }
            }

            return answerLength;
        }
    }
}
