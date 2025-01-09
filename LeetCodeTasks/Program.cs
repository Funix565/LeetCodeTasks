using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = CountingWordsWithGivenPrefix.Solve(["leetcode", "win", "loops", "success"], "code");
            Console.WriteLine(res);
        }
    }
}
