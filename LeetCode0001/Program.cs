namespace LeetCode0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
             * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
             * 你可以按任意顺序返回答案。
             * 
             * 示例 1：
             * 输入：nums = [2,7,11,15], target = 9
             * 输出：[0,1]
             * 解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
             * 
             * 示例 2：
             * 输入：nums = [3,2,4], target = 6
             * 输出：[1,2]
             *  
             * 示例 3：
             * 输入：nums = [3,3], target = 6
             * 输出：[0,1]
             */
            var result = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine(string.Join(",",result));
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { j, i };
                    }
                }
            }
            return new int[0];
        }
    }
}