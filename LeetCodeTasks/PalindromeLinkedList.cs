using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/palindrome-linked-list/

    public class PalindromeLinkedList
    {
        public static bool Solve(ListNode head)
        {
            Stack<int> backwards = new();

            ListNode wp = head;

            // We need this loop to fill the Stack
            while (wp != null)
            {
                backwards.Push(wp.val);
                wp = wp.next;
            }

            // Now Stack contains all values of LinkedList but in reverse order
            // Loop through the LinkedList one more time and compare vals
            while (head != null)
            {
                int val = backwards.Pop();
                if (val != head.val)
                {
                    return false;
                }

                head = head.next;
            }

            return true;
        }
    }
}
