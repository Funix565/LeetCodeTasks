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

            int open = 0;
            int unlocked = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                if (locked[i] == '0')
                {
                    ++unlocked;
                }
                else if (s[i] == '(')
                {
                    ++open;
                }
                else if (s[i] == ')')
                {
                    if (open > 0)
                    {
                        --open;
                    }
                    else if (unlocked > 0)
                    {
                        --unlocked;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            int balance = 0;
            for (int i = s.Length - 1; i >= 0; --i)
            {
                if (locked[i] == '0')
                {
                    --balance;
                    --unlocked;
                }
                else if (s[i] == '(')
                {
                    ++balance;
                    --open;
                }
                else if (s[i] == ')')
                {
                    --balance;
                }

                if (balance > 0)
                {
                    return false;
                }

                if (unlocked == 0 && open == 0)
                {
                    break;
                }
            }

            if (open > 0)
            {
                return false;
            }

            return true;
        }
    }
}
