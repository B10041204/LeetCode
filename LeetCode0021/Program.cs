namespace LeetCode0021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            //var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            //ListNode list1 = null;
            //ListNode list2 = new ListNode(0);
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(8))));
            var result = new Solution().MergeTwoLists(list1, list2);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.WriteLine("Hello, World!");
        }
    }
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
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            if (list1 == null || list2 == null)
            {
                return list1 ?? list2;
            }

            var result = new ListNode();
            var head = result;
            while (list1 != null && list2 != null)
            {
                if (list1.val >= list2.val)
                {
                    result.val = list2.val;
                    list2 = list2.next;
                }
                else
                {
                    result.val = list1.val;
                    list1 = list1.next;
                }
                result.next = new ListNode();
                result = result.next;
            }
            if (list1 != null)
            {
                result.val = list1.val;
                result.next = list1.next;
            }
            if (list2 != null)
            {
                result.val = list2.val;
                result.next = list2.next;
            }
            return head;
        }
    }
}