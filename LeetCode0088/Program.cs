namespace LeetCode0088
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            new Solution().Merge(nums1, 3, nums2, 3);
            var nums3= new int[] { 1 };
            var nums4 = new int[] { };
            new Solution().Merge(nums3, 1, nums4, 0);
            var nums5 = new int[] { 0 };
            var nums6 = new int[] { 1 };
            new Solution().Merge(nums5, 0, nums6, 1);

        }
    }
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var aindex = m - 1;
            var bindex = n - 1;
            var index = nums1.Length - 1;

            // 都有时候循环
            while (aindex >= 0 && bindex >= 0)
            {
                if (nums1[aindex] > nums2[bindex])
                {
                    nums1[index] = nums1[aindex];
                    aindex--;
                }
                else
                {
                    nums1[index] = nums2[bindex];
                    bindex--;
                }
                index--;
            }
            // bindex 有可能为负数，此时 bindex + 1 == 0
            while (bindex + 1 > 0)
            {
                nums1[index] = nums2[bindex];
                bindex--;
                index--;
            }
            while (aindex + 1 > 0)
            {
                nums1[index] = nums1[aindex];
                aindex--;
                index--;
            }
        }
    }
}