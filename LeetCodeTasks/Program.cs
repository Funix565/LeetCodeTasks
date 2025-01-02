using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = CountVowelStringsInRanges.Solve(["aba", "bcb", "ece", "aa", "e"], [[0, 2], [1, 4], [1, 1]]);
            foreach (var s in ans)
            {
                Console.WriteLine(s);
            }
        }
    }
}
