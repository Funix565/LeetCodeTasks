using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.IList<string> list = FizzBuzz.Solve(15);
            foreach(var l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine(FizzBuzz.Solve(3));
        }
    }
}
