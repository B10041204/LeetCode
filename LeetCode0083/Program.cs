namespace LeetCode0083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var list = new ListNode(1, new ListNode(1, new ListNode(2)));
            //var list = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
            var result = new Solution().DeleteDuplicates(list);
            while (result!=null)
            {
                Console.WriteLine(result.val);
                result=result.next;
            }
        }
    }

    /**
    * Definition for singly-linked list.
    */
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if(head== null) return head;

            var current = head;
            var result = current;
            var pre = head.next;
            while (current != null && pre != null)
            {
                if (pre.val == current.val)
                {
                    current.next = pre.next;
                    pre = pre.next;
                }
                else
                {
                    current.next = pre;
                    current = current.next;
                }
            }
            return result;
        }
    }
}