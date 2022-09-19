using System;

namespace LeetCodeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            Console.WriteLine(PalindromeLinkedList.Solve(ln));
        }
    }
}
