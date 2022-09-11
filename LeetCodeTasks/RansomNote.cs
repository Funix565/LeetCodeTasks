using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/ransom-note/
    // Done it on the 4th attempt.
    // 1) Dictionary was <char, bool> -- exception on duplicate key, impossible to track the amount of letters
    // 2) Bad usage of "count" variable to track letters. One variable for the whole loop without renew. "aab", "baa" -- fail
    // 3) Again issues with "count". Prefix or postfix, wrong place for increment. "fffbfg", "effjfggbffjdgbjjhhdegh" -- fail
    // 4) Great. Remove "count" variable. Use the same approach as in the second loop. Simply increment for the dic-value itself, no extra vars.

    public class RansomNote
    {
        public static bool Solve(string ransomNote, string magazine)
        {
            IDictionary<char, int> magazineLettersUsage = new Dictionary<char, int>();

            // the main condition to perform any calculations
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }

            foreach (char c in magazine)
            {
                // anyway adds the element for the first time
                if (magazineLettersUsage.TryAdd(c, 1) == false)
                {
                    // the element with the given key exists in the dictionary
                    magazineLettersUsage[c]++;
                }
            }

            foreach (char r in ransomNote)
            {
                // Act only when letter exists and is present in a dic
                magazineLettersUsage.TryGetValue(r, out int value);
                if (value == 0)
                {
                    return false;   
                }

                magazineLettersUsage[r]--;
            }

            return true;
        }
    }
}
