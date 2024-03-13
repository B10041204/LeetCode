namespace LeetCode0002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 输入：l1 = [2,4,3], l2 = [5,6,4]
             * 输出：[7,0,8]
             * 解释：342 + 465 = 807.
             */
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var result=new Solution().AddTwoNumbers(l1, l2);
            while(result != null)
            {
                Console.Write(result.val.ToString());
                result= result.next;
            }

            Console.WriteLine();

            ListNode l3 = new ListNode(0);
            ListNode l4 = new ListNode(0);

            result = new Solution().AddTwoNumbers(l3, l4);
            while (result != null)
            {
                Console.Write(result.val.ToString());
                result = result.next;
            }

            Console.WriteLine();

            //[9,9,9,9,9,9,9] [9,9,9,9]
            ListNode l5 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l6 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            result = new Solution().AddTwoNumbers(l5, l6);
            while (result != null)
            {
                Console.Write(result.val.ToString());
                result = result.next;
            }

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
        /*
         *给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
         *请你将两个数相加，并以相同形式返回一个表示和的链表。
         *你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
         *
         *
         *示例 1：
         *输入：l1 = [2,4,3], l2 = [5,6,4]
         *输出：[7,0,8]
         *解释：342 + 465 = 807.
         *
         *示例 2：
         *输入：l1 = [0], l2 = [0]
         *输出：[0]
         *
         *示例 3：
         *输入：l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
         *输出：[8,9,9,9,0,0,0,1] 
         */
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //结果
            var result = new ListNode();
            var node = result;
            var currentVal = 0;
            if (l1 != null) currentVal += l1.val;
            if (l2 != null) currentVal += l2.val;
            var into = currentVal / 10;
            node.val = currentVal % 10;
            //遍历
            while ((l1 != null && l1.next != null) || (l2 != null && l2.next != null))
            {
                l1 = l1?.next;
                l2 = l2?.next;
                currentVal = 0;
                if (l1 != null) currentVal += l1.val;
                if (l2 != null) currentVal += l2.val;
                node.next = new ListNode((currentVal + into) % 10);
                into = (currentVal + into) / 10;
                node = node.next;
            }
            if (into != 0)
            {
                node.next = new ListNode(into);
            }
            return result;
        }
    }
}