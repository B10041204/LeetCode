namespace LeetCode0007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().Reverse(123));
            Console.WriteLine(new Solution().Reverse(-123));
            Console.WriteLine(new Solution().Reverse(-120));
            Console.WriteLine(new Solution().Reverse(120));
            Console.WriteLine(new Solution().Reverse(0));
            Console.WriteLine(new Solution().Reverse(1534236469));
            Console.WriteLine(new Solution().Reverse(-2147483648));
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            var flag = x > 0;
            var queue = new Queue<int>();
            do
            {
                queue.Enqueue(Math.Abs(x % 10));
                x = x / 10;
            } while (x != 0);

            if (int.TryParse(string.Join("", queue), out int result))
            {
                return flag ? result : 0 - result;
            }
            else
            {
                return default(int);
            }
        }
    }
}