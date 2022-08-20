using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/fizz-buzz/

    public class FizzBuzz
    {
        // Approach 1: Naive Approach If-ElseIf-Else
        public static IList<string> Solve(int n)
        {
            List<string> res = new();
            for (int i = 1; i <= n; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    res.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    res.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    res.Add("Buzz");
                }
                else
                {
                    res.Add(i.ToString());
                }
            }

            return res;
        }
    }
}
