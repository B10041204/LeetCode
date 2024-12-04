namespace LeetCode0035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new Solution().SearchInsert(new int[] { 1, 3, 5, 6 }, 7).ToString());
        }
    }
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var pre = 0;
            var next = nums.Length - 1;
            var current = (int)Math.Floor((decimal)nums.Length / 2);
            while(pre<= next)
            {
                if(nums[current] == target)
                {
                    return current;
                }
                else if(nums[current] > target)
                {
                    next = current - 1;
                    current = (pre + next) / 2;
                }
                else
                {
                    pre = current + 1;
                    current = (pre + next) / 2;
                }
            }
            if (nums[current] >target)
            {
                return current;
            }
            else
            {
                return current + 1;
            }
        }
    }
}