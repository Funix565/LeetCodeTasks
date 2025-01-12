using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/check-if-a-parentheses-string-can-be-valid/

    public class CheckIfParenthesesStringCanBeValid
    {
        public static bool Solve(string s, string locked)
        {
            // check size, must divide by two
            if (s.Length % 2 != 0)
            {
                return false;
            }

            // check first char, if closed and can't be changed
            if (s[0] == ')' && locked[0] == '1')
            {
                return false;
            }

            // check last char, if opened and can't be changed
            if (s[s.Length - 1] == '(' && locked[locked.Length - 1] == '1')
            {
                return false;
            }

            int balance = 0;
            int unlocked = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(')
                {
                    ++balance;
                }
                else if (s[i] == ')')
                {
                    --balance;
                }

                if (balance < 0 && locked[i] == '0')
                {
                    ++balance;
                }
                else if (balance < 0 && locked[i] == '1' && unlocked > 0)
                {
                    --unlocked;
                    ++balance;
                }

                if (locked[i] == '0')
                {
                    ++unlocked;
                }
            }

            return unlocked >= balance;
        }
    }
}
