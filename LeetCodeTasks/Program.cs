using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Every rows filled with 1
            //Console.WriteLine(
            int[] res = KWeakestRowsInMatrix.Solve(new int[][]
            {
            new int[] { 1, 1, 0, 0 },
            new int[] { 1, 1, 1, 0 },
            new int[] { 1, 0, 0, 0 },
            new int[] { 1, 0, 0, 0 },
            //new int[] { 1, 1, 1, 1, 1 }
            }, 2);

            Array.ForEach(res, Console.WriteLine);
                //);
        }
    }
}
