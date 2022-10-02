using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { -7, -3, 2, 3, 11 };
            //Console.WriteLine(SquaresOfASortedArray.Solve(ar));
            Array.ForEach(SquaresOfASortedArray.Solve(ar), Console.WriteLine);
        }
    }
}
