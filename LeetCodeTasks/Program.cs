using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new(1);
            Console.WriteLine(MiddleLinkedList.Solve(ln).val);
        }
    }
}
