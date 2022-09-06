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
            ListNode middle = head;
            ListNode end = head;

            // Middle moves by one node.
            // End moves by two nodes.
            // Our middle node only moves up whenever the size of the list grows by two nodes.
            // That's why we need a check for a current node and the next node

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;
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
