using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> res = StringMatchingInArray.Solve(["mass", "as", "glass", "ass", "overmass"]);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
