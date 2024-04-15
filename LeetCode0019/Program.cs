namespace LeetCode0019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = new Solution().RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
            //var result = new Solution().RemoveNthFromEnd(new ListNode(1), 1);
            var result = new Solution().RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 1);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.WriteLine("Hello, World!");
        }
    }

    /**
 * Definition for singly-linked list. */
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var count = 0;
            var org = head;
            var result = org;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            var index = count - n;
            var currentIndex = 0;
            var pre = org;
            var current = org;
            if (n == count)
            {
                result = result.next;
            }
            else
            {
                while (org != null && n < count)
                {
                    if (index == currentIndex)
                    {
                        pre.next = current.next;
                    }
                    else
                    {
                        pre = org;
                        current = org.next;
                        currentIndex++;
                    }
                    org = org.next;
                }
            }
            return result;
        }
    }

}