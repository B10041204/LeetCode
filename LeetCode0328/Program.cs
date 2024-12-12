namespace LeetCode0328
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = new Solution().OddEvenList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
    /**
    * Definition for singly-linked list.
    */
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            var current = head;
            var index = 0;
            var even = head.next;
            while (head != null)
            {
                if (index % 2 == 0) 
                {
                    even.next = head.next.next;
                    even = even.next;
                }
                head = head.next;
                index++;
            }
            return current;
        }
    }
}