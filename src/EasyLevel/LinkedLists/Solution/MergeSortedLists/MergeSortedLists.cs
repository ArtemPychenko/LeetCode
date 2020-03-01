
namespace LinkedLists.Solution.MergeSortedLists
{
    public class MergeSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode prehead = new ListNode(-1);

            ListNode prev = prehead;

            while (l1 != null && l2 != null)
            {
                if (l1.Value <= l2.Value)
                {
                    prev.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    prev.Next = l2;
                    l2 = l2.Next;
                }

                prev = prev.Next;
            }

            prev.Next = l1 ?? l2;

            return prehead.Next;
        }
    }

    public class ListNode
    {
        public ListNode(int x)
        {
           Value = x;
        }
        public int Value { get; set; }

        public ListNode Next { get; set; }
    }
}
