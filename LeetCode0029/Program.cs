namespace LeetCode0029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new Solution().Divide(-2147483648, -1).ToString());
        }
    }
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            var result = (long)dividend / (long)divisor;
            if (result > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (result < int.MinValue)
            {
                return int.MinValue;
            }
            else
            {
                return (int)result;
            }
        }
    }
}