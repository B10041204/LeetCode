namespace LeetCode0066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", new Solution().PlusOne(new int[] { 0 })));
            Console.WriteLine(string.Join("", new Solution().PlusOne(new int[] { 1, 2, 3 })));
            Console.WriteLine(string.Join("", new Solution().PlusOne(new int[] { 9, 9, 9 })));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var pre = 1;
            var index = digits.Length - 1;
            while (index >= 0)
            {
                var total = digits[index] + pre;
                digits[index] = total % 10;
                pre = total / 10;
                if (pre == 0) break;
                index--;
            }
            if (index == -1 && pre == 1)
            {
                digits = (new int[1] { 1 }).Concat(digits).ToArray();
            }
            return digits;
        }
    }
}