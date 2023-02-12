using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "ooolleoooleh";
            var ans = CheckInclusion.Solve(s1, s2);
            Console.WriteLine(ans);
        }
    }
}
