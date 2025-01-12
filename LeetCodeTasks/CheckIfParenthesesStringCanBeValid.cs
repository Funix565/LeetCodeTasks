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

            Stack<char> parentheses = new Stack<char>();
            bool isValid = false;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(')
                {
                    parentheses.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (parentheses.TryPeek(out char item))
                    {
                        if (item == '(')
                        {
                            parentheses.Pop();
                            isValid = true;
                        }
                    }
                    else
                    {
                        if (s[i] == ')')
                        {
                            if (locked[i] == '0')
                            {
                                parentheses.Push('(');
                            }
                            else if (locked[i] == '1')
                            {
                                isValid = false;
                            }
                        }
                    }
                }
            }

            if (isValid)
            {
                return true;
            }
            else
            {
                parentheses.Clear();
            }

            for (int i = s.Length - 1; i >= 0; --i)
            {
                if (s[i] == ')')
                {
                    parentheses.Push(s[i]);
                }
                else if (s[i] == '(')
                {
                    if (parentheses.TryPeek(out char item))
                    {
                        if (item == ')')
                        {
                            parentheses.Pop();
                            isValid = true;
                        }
                    }
                    else
                    {
                        if (s[i] == '(')
                        {
                            if (locked[i] == '0')
                            {
                                parentheses.Push(')');
                            }
                            else if (locked[i] == '1')
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return isValid;
        }
    }
}
