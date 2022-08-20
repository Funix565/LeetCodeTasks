using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = RunningSumOf1dArray.Solve(new int[] { 1, 2, 3, 4 });
            Array.ForEach(res, Console.WriteLine);
            Console.WriteLine(RunningSumOf1dArray.Solve(new int[] { 1, 2, 3, 4 }));
        }
    }
}
