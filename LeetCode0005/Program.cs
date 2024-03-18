using System.Drawing;

namespace LeetCode0005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestPalindrome("babad"));
            Console.WriteLine(new Solution().LongestPalindrome("cbbd"));
            Console.WriteLine(new Solution().LongestPalindrome("able was I ere I saw elba"));
            Console.WriteLine(new Solution().LongestPalindrome("ac"));
            Console.WriteLine(new Solution().LongestPalindrome("bb"));
            Console.WriteLine(new Solution().LongestPalindrome("abb"));
            Console.WriteLine(new Solution().LongestPalindrome("aacabdkacaa"));
            Console.WriteLine(new Solution().LongestPalindrome("abacab"));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var result = new HashSet<string>();
            var total = string.Empty;
            //奇数
            for (int i = 0; i <= s.Length - 1; i++)
            {
                var index = 0;
                for (index = 1; index <= i; index++)
                {
                    if (i - index >= 0 && i + index <= s.Length - 1)
                    {
                        if (s[i - index] != s[i + index])
                        {
                            result.Add(s.Substring(i - (index - 1), 2 * index - 1));
                            break;
                        }
                        else
                        {
                            total = s.Substring(i - index, 2 * index + 1);
                        }
                    }
                }
                if (index > i && !string.IsNullOrEmpty(total))
                {
                    result.Add(total);
                }
            }
            //偶数
            for (int i = 1; i <=s.Length - 1; i++)
            {
                var index = 0;

                for (index = 0; index < i; index++)
                {
                    if(i - index - 1 >= 0 && i + index <= s.Length - 1)
                    {
                        if (s[i - index - 1] != s[i + index])
                        {
                            if (index != 0)
                            {
                                result.Add(s.Substring(i - index, 2 * index));
                            }
                            break;
                        }
                        else
                        {
                            total = s.Substring(i - index - 1, 2 * (index+1));
                        }
                    }
                }
                if (index >= i && !string.IsNullOrEmpty(total))
                {
                    result.Add(total);
                }
            }
            return result.Count > 0 ? result.First(x => x.Length == result.Max(y => y.Length)) : s[0].ToString();

        }
    }
}