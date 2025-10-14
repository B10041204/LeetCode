namespace LeetCode0033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var solution = new Solution();
            Console.WriteLine(solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2, 3 }, 0)); // 4
            Console.WriteLine(solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3)); // -1
            Console.WriteLine(solution.Search(new int[] { 1 }, 0)); // -1

        }
    }
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int count= nums.Length;
            if (count == 0) return -1;
            if (count == 1)
            {
                return nums[0] == target ? 0 : -1;
            }
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[0] <= nums[mid])
                {
                    if (nums[0] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[count - 1])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
