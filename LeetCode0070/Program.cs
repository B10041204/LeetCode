namespace LeetCode0070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new Solution().ClimbStairs(45));
        }
    }

    public class Solution
    {
        public int ClimbStairs(int n)
        {
            //递归方法超时，45通不过
            //return ClimbRecursive(n);
            return Climbative(n);
        }

        private int ClimbRecursive(int n)
        {
            if (n <= 2) return n;
            return ClimbRecursive(n - 1) + ClimbRecursive(n - 2);
        }

        private int Climbative(int n)
        {
            if (n <= 2) return n;
            int a = 1, b = 2;
            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}