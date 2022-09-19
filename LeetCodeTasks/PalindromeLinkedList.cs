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
            ListNode wp = head;

            // One node is a palindrome
            if (wp.next == null)
            {
                return true;
            }

            // Move head to the middle
            while (head != null)
            {
                int val = GetLastAndRemove(wp);

                if (head.val == val)
                {
                    head = head.next;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // Remove last node and move tail in reverse order to the middle
        private static int GetLastAndRemove(ListNode node)
        {
            // Find the penultimate node
            while (node.next.next != null)
            {
                node = node.next;
            }

            int val = node.next.val;
            node.next = null;
            return val;
        }
    }
}
