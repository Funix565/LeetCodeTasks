using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/middle-of-the-linked-list/

    public class MiddleLinkedList
    {
        public static ListNode Solve(ListNode head)
        {
            // Find the number of elements in a list
            int count = 0;
            ListNode wn = head;
            while (wn != null)
            {
                wn = wn.next;
                ++count;
            }

            // Special case with one node
            if (count == 1)
            {
                return head;
            }

            // Index of the middle node
            int middle = count / 2;
            wn = head;
            count = 0;

            // Iterate half the number of elements
            while (wn != null)
            {
                if (count == middle)
                {
                    break;
                }
                wn = wn.next;
                ++count;
            }

            return wn;
        }
    }

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
