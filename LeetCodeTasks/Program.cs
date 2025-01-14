using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = FindThePrefixCommonArrayOfTwoArrays.Solve([1,2,3,4,5,6,7,8,9], [5,6,9,1,8,3,7,2,4]);
            Array.ForEach(res, Console.WriteLine);
        }
    }
}
