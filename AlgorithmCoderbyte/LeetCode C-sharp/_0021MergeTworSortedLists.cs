using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoderbyte.LeetCode_C_sharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val, ListNode next)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class _0021MergeTworSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy head for the merged list
            ListNode head = new ListNode(0, null);
            ListNode current = head;

            // Loop while both lists have nodes remaining
            while (list1 != null && list2 != null)
            {
                // Choose the smaller node and append it to the merged list
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Append any remaining nodes from the longer list
            current.next = list1 ?? list2;

            return head.next;
        }
    }
}
