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
        // Approach 2: String Concatenation
        public static IList<string> Solve(int n)
        {
            List<string> res = new(n);
            for (int i = 1; i <= n; ++i)
            {
                bool by3 = i % 3 == 0;
                bool by5 = i % 5 == 0;

                string tmp = "";

                if (by3)
                {
                    tmp += "Fizz";
                }
                if (by5)
                {
                    tmp += "Buzz";
                }

                if (String.IsNullOrEmpty(tmp))
                {
                    tmp += i.ToString();
                }

                res.Add(tmp);
            }

            return res;
        }
    }
}
