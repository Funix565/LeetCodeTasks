using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = CheckIfParenthesesStringCanBeValid.Solve("()((()))()()))((())(", "10010101001111010100");
            Console.WriteLine(answer);
        }
    }
}
