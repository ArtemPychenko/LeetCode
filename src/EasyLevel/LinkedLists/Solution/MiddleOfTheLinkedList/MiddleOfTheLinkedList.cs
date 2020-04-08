
using System;
using System.Collections.Generic;

namespace LinkedLists.Solution.MiddleOfTheLinkedList
{
    public class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var list = new List<int>();
            ListNode initial = head;

            while (initial != null)
            {
                list.Add(initial.val);

                initial = initial.next;
            }

            var counter = Math.Ceiling((decimal)(list.Count / 2));

            initial = head;

            while (counter != 0)
            {
                initial = initial.next;
                counter--;
            }

            return initial;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}
