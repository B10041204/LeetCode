namespace LeetCode0009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPalindrome(123456));
            Console.WriteLine(new Solution().IsPalindrome(1234564321));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}