using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MinNumberOfOperationsToMoveAllBallsToEachBox.Solve("110");
            Array.ForEach(res, Console.WriteLine);
        }
    }
}
