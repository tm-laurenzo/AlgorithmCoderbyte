using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode
{
    public static class _02AddTwoNumbers
    {

        static string question =
         @"  You are given two linked lists representing two non-negative numbers. The digits are
             stored in reverse order and each of their nodes contain a single digit. Add the two numbers
             and return it as a linked list. Input: (2 ->4 ->3) + (5 ->6 ->4) Output: 7 ->0 ->8
         ";
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class Solution
    {
            public ListNode addTwoNumbers(ListNode l1, ListNode l2)
            {
                int carry = 0;
                ListNode newHead = new ListNode(0);
                ListNode p1 = l1, p2 = l2, p3 = newHead;
                while (p1 != null || p2 != null)
                {
                    if (p1 != null)
                    {
                        carry += p1.val;
                        p1 = p1.next;
                    }
                    if (p2 != null)
                    {
                        carry += p2.val;
                        p2 = p2.next;
                    }
                    p3.next = new ListNode(carry % 10);
                    p3 = p3.next;
                    carry /= 10;
                }
                if (carry == 1)
                    p3.next = new ListNode(1);
                return newHead.next;
            }

        //Check the video
        public ListNode addTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode dummy_head = new ListNode(0);
            ListNode l3 = dummy_head;

            int carry = 0;
            while(l1 != null || l2 != null)
            {
                int l1_val = (l1 != null) ? l1.val : 0;
                int l2_val = (l2 != null) ? l2.val : 0;

                int current_sum = l1_val + l2_val + carry;
                carry = current_sum / 10;
                int last_digit = current_sum % 10;

                ListNode new_node = new ListNode(last_digit);
                l3.next = new_node;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                l3 = l3.next;
            }

            if(carry > 0)
            {
                ListNode new_node = new ListNode(carry);
                l3.next = new_node;
                l3 = l3.next;
            }
            return dummy_head.next;
        }
    }
}
