using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/roman-to-integer/

    // Problem is simpler to solve by working the string from back to front and using a map.
    public class RomanToInt
    {
        public static int Solve(string s)
        {
            int result = 0;
            char prev = default;

            // Loop through every character and construct the final number somehow
            // Payy attention to substraction
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I':
                        result += 1;
                        prev = 'I';
                        break;
                    case 'V':
                        // Check instance 1) I can be placed before V
                        if (prev.Equals('I'))
                        {
                            // Sub earlier number
                            result -= 1;
                            // Assign actual meaning
                            result += (5 - 1);
                        }
                        else
                        {
                            result += 5;
                        }
                        prev = 'V';
                        break;
                    case 'X':
                        // Check instance 2) I can be placed before X
                        if (prev.Equals('I'))
                        {
                            result -= 1;
                            result += (10 - 1);
                        }
                        else
                        {
                            result += 10;
                        }
                        prev = 'X';
                        break;
                    case 'L':
                        // Check instance 3) X can be placed before L
                        if (prev.Equals('X'))
                        {
                            result -= 10;
                            result += (50 - 10);
                        }
                        else
                        {
                            result += 50;
                        }
                        prev = 'L';
                        break;
                    case 'C':
                        // Check instance 4) X can be placed before C
                        if (prev.Equals('X'))
                        {
                            result -= 10;
                            result += (100 - 10);
                        }
                        else
                        {
                            result += 100;
                        }
                        prev = 'C';
                        break;
                    case 'D':
                        // Check instance 5) C can be placed before D
                        if (prev.Equals('C'))
                        {
                            result -= 100;
                            result += (500 - 100);
                        }
                        else
                        {
                            result += 500;
                        }
                        prev = 'D';
                        break;
                    case 'M':
                        // Check instance 6) C can be placed before M
                        if (prev.Equals('C'))
                        {
                            result -= 100;
                            result += (1000 - 100);
                        }
                        else
                        {
                            result += 1000;
                        }
                        prev = 'M';
                        break;
                }
            }

            return result;
        }
    }
}
