using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = CountVowelStringsInRanges.Solve(["a", "e", "i"], [[0, 2], [0, 1], [2, 2]]);
            foreach (var s in ans)
            {
                Console.WriteLine(s);
            }
        }
    }
}
