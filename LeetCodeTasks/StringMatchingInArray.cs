using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/string-matching-in-an-array/

    public class StringMatchingInArray
    {
        public static IList<string> Solve(string[] words)
        {
            // todo: can use list, if `break` after adding
            HashSet<string> answer = new HashSet<string>();

            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = i + 1; j < words.Length; ++j)
                {
                    // TODO: Replace Contains with KMP
                    if (words[j].Length < words[i].Length && words[i].Contains(words[j]))
                    {
                        answer.Add(words[j]);
                        // todo: break, no need to continue, we found a substring
                    }
                    // TODO: Replace Contains with KMP
                    else if (words[i].Length < words[j].Length && words[j].Contains(words[i]))
                    {
                        answer.Add(words[i]);
                        // todo: break, no need to continue, we found a substring
                    }
                }
            }

            return answer.ToList();
        }
    }
}
