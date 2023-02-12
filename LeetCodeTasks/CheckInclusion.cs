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

            Dictionary<char, Tuple<int, int>> charsEtalon = new Dictionary<char, Tuple<int, int>>();
            for (int i = 0, len = s1.Length; i < len; ++i)
            {
                if (charsEtalon.TryAdd(s1[i], new Tuple<int, int>(1, 1)) == false)
                {
                    charsEtalon[s1[i]] = Tuple.Create(charsEtalon[s1[i]].Item1 + 1, charsEtalon[s1[i]].Item2 + 1);
                }
            }

            Dictionary<char, Tuple<int, int>> chars = new(charsEtalon);
            int count = s1.Length;

            for (int i = 0; i <= s2.Length - s1.Length; ++i)
            {
                chars = new(charsEtalon);
                count = s1.Length;
                for (int j = i; j <= i + s1.Length - 1; ++j)
                {
                    if (chars.ContainsKey(s2[j]))
                    {
                        if (chars[s2[j]].Item1 > 0)
                        {
                            chars[s2[j]] = Tuple.Create(chars[s2[j]].Item1 - 1, chars[s2[j]].Item2);
                            
                            --count;
                            if (count == 0)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            count = s1.Length;
                            if (count > s2.Length - i)
                            {
                                return false;
                            }
                            chars = new(charsEtalon);
                        }
                    }
                    else
                    {
                        count = s1.Length;
                        if (count > s2.Length - i)
                        {
                            return false;
                        }
                        chars = new(charsEtalon);
                    }
                }
            }

            return false;
        }
    }
}
