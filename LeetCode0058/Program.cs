namespace LeetCode0058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LengthOfLastWord("luffy is still joyboy"));
            Console.WriteLine(new Solution().LengthOfLastWord("Hello World"));
            Console.WriteLine(new Solution().LengthOfLastWord("   fly me   to   the moon  "));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var current = s.Length - 1;
            var pre = int.MinValue;
            while (current >= 0)
            {
                if (s[current] != ' ' && pre == int.MinValue)
                {
                    pre = current;
                }
                else if ((s[current] == ' ' && pre == int.MinValue) || (s[current] != ' ' && pre != int.MinValue))
                {
                    current--;
                }
                else
                {
                    break;
                }
            }
            return pre - current;
        }
    }
}