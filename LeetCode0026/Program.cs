namespace LeetCode0026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().RemoveDuplicates(new int[] { 1, 1, 2 }));
            Console.WriteLine(new Solution().RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var pre = 1;
            var current = 0;
            var total = nums.Length;
            var count = total;

            while (current < total && pre < total)
            {
                if (nums[pre] == nums[current])
                {
                    pre++;
                    count--;
                }
                else
                {
                    nums[++current] = nums[pre++];
                    
                }
            }
            return count;
        }
    }
}