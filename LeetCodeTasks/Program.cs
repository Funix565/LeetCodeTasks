using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new(1, new(2, new(3, new(4, new(5, new(6))))));
            Console.WriteLine(MiddleLinkedList.Solve(ln).val);
        }
    }
}
