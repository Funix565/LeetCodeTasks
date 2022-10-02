using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { -4, -1, 0, 3, 10 };
            //Console.WriteLine(SquaresOfASortedArray.Solve(ar));
            Array.ForEach(SquaresOfASortedArray.Solve(ar), Console.WriteLine);
        }
    }
}
