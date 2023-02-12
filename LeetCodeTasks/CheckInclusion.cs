using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/permutation-in-string/

    public class CheckInclusion
    {
        public static bool Solve(string s1, string s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }
            if (s1.Length > s2.Length)
            {
                return false;
            }

            HashSet<char> chars = new(s1.Length);
            for (int i = 0, len = s1.Length, k = len / 2; i <= len / 2 && k < len; ++i, ++k)
            {
                chars.Add(s1[i]);
                chars.Add(s1[k]);
            }

            int count = s1.Length;

            for (int i = 0, len = s2.Length; i < len; ++i)
            {
                if (chars.Contains(s2[i]))
                {
                    --count;
                    if (count == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    count = s1.Length;
                    if (count >= len - i)
                    {
                        break;
                    }
                }
            }

            return false;
        }
    }
}
