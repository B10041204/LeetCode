namespace LeetCode0011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Console.WriteLine(new Solution().MaxArea(new int[] { 1, 1 }));
            var startTime = DateTimeOffset.Now;
            Console.WriteLine(new Solution().MaxArea(new Mock().Array));
            var endTime = DateTimeOffset.Now;
            Console.WriteLine($"总计耗时：{(endTime - startTime).TotalSeconds}");
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var area = int.MinValue;

            var low = 0;

            var high = height.Length - 1;

            while (low < high)
            {
                if (height[low]> height[high])
                {
                    var temp = height[high] * (high - low);
                    if (temp > area)
                    {
                        area = temp;
                    }
                    high--;
                }
                else
                {
                    var temp=height[low] * (high - low);
                    if (temp > area)
                    {
                        area = temp;
                    }
                    low++;
                }
            }

            return area;
        }
    }
}