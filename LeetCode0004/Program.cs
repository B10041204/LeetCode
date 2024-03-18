namespace LeetCode0004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 100001 }, new int[] { 100000 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 2, 3 }, new int[] { 1 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 3 }, new int[] { -2, -1 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 7 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 4 }, new int[] { 2, 3 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 2, 3, 5 }, new int[] { 1, 4 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 2, 3, 4 }, new int[] { 1, 5 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 1, 1, 3, 3, 3 }, new int[] { 1, 1, 1, 3, 3, 3 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 0, 0 }, new int[] { 0, 0 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 1, 1 }));
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 2, 4, 5 }, new int[] { 3 }));
            Console.WriteLine("Hello, World!");
        }
    }

    /*
     * 
     * 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
     * 
     * 算法的时间复杂度应该为 O(log (m+n)) 。
     * 
     *示例 1：
     *
     *输入：nums1 = [1,3], nums2 = [2]
     *输出：2.00000
     *解释：合并数组 = [1,2,3] ，中位数 2
     *
     *
     *示例 2：
     *
     *输入：nums1 = [1,2], nums2 = [3,4]
     *输出：2.50000
     *解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5
     */
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //都为空
            if (nums1.Length == 0 && nums2.Length == 0) return 0;
            //nums2不为空
            if (nums1.Length == 0 && nums2.Length != 0)
            {
                var middle = nums2.Length / 2;
                if (nums2.Length % 2 == 0)
                {
                    var bigger = nums2[middle];
                    var smaller = nums2[middle - 1];
                    return (double)(bigger + smaller) / 2;
                }
                else
                {
                    return nums2[middle];
                }
            }
            //nums1不为空
            if (nums1.Length != 0 && nums2.Length == 0)
            {
                var middle = nums1.Length / 2;
                if (nums1.Length % 2 == 0)
                {
                    var bigger = nums1[middle];
                    var smaller = nums1[middle - 1];
                    return (double)(bigger + smaller) / 2;
                }
                else
                {
                    return nums1[middle];
                }
            }
            //nums1整体比nums2小
            if (nums1[nums1.Length - 1] <= nums2[0])
            {
                var all = nums1[0..].Concat(nums2[0..]).ToList();
                var middle = all.Count() / 2;
                if (all.Count() % 2 == 0)
                {
                    var bigger = all[middle];
                    var smaller = all[middle - 1];
                    return (double)(bigger + smaller) / 2;
                }
                else
                {
                    return all[middle];
                }
            }
            //nums2整体比nums1小
            else if (nums2[nums2.Length - 1] < nums1[0])
            {
                var all = nums2[0..].Concat(nums1[0..]).ToList();
                var middle = all.Count() / 2;
                if (all.Count() % 2 == 0)
                {
                    var bigger = all[middle];
                    var smaller = all[middle - 1];
                    return (double)(bigger + smaller) / 2;
                }
                else
                {
                    return all[middle];
                }
            }
            //混合
            else
            {
                var start = BinarySearch(nums1, nums2[0], 0, nums1.Length - 1);
                var end = BinarySearch(nums1, nums2[nums2.Length - 1], 0, nums1.Length - 1, false);
                var all = nums1.ToList().GetRange(0, start);
                var index = 0;
                for (var i = start + 1; i < end; i++)
                {
                    if (nums1[i] < nums2[index])
                    {
                        all.Add(nums1[i]);
                        all.Add(nums2[index++]);
                    }
                    else
                    {
                        all.Add(nums2[index++]);
                        all.Add(nums1[i]);
                    }
                    if (index >= nums2.Length)
                    {
                        break;
                    }
                }

                while (index < nums2.Length)
                {
                    if (all != null && all.Count > 0)
                    {
                        int current = BinarySearch(all.ToArray(), nums2[index], 0, all.Count - 1);
                        if (all[current] < nums2[index])
                        {
                            all.Insert(current + 1, nums2[index++]);
                        }
                        else if(all[current]  snums2[index])
                        {
                            all.Insert(current, nums2[index++]);
                        }
                    }
                    else
                    {
                        all = new List<int>();
                        all.InsertRange(index, nums2);
                        break;
                    }
                }
                while (end < nums1.Length)
                {
                    if (all != null && all.Count > 0)
                    {
                        int current = BinarySearch(all.ToArray(), nums1[end], 0, all.Count - 1);
                        if (all[current] < nums1[end])
                        {
                            all.Insert(current + 1, nums1[end++]);
                        }
                        else if (all[current] > nums1[end])
                        {
                            all.Insert(current, nums1[end++]);
                        }
                    }
                    else
                    {
                        all = new List<int>();
                        all.InsertRange(index, nums1);
                        break;
                    }
                }
                var middle = all.Count() / 2;
                if (all.Count() % 2 == 0)
                {
                    var bigger = all[middle];
                    var smaller = all[middle - 1];
                    return (double)(bigger + smaller) / 2;
                }
                else
                {
                    return all[middle];
                }
            }
        }

        public int BinarySearch(int[] array, int find, int low, int high, bool isLower = true)
        {
            while (low < high)
            {
                int middle = low + (high - low) / 2;
                if (find < array[middle])
                {
                    high = middle - 1;
                }
                else if (find == array[middle])
                {
                    return middle;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return isLower ? low : high;
        }
    }
}