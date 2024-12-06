namespace LeetCode0069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new Solution().MySqrt(2147395600));
        }
    }
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1) { return x; }

            for (int i = 1; i < x; i++)
            {
                if (i * i > x || i * i < 0) return i - 1;
            }

            return 1;
        }
    }
}