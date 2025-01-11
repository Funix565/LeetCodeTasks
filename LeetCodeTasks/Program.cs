using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> res = WordSubsets.Solve(["acaac", "cccbb", "aacbb", "caacc", "bcbbb"], ["c", "cc", "b"]);
            Array.ForEach(res.ToArray(), Console.WriteLine);
        }
    }
}
