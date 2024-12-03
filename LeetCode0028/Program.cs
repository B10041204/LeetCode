namespace LeetCode0028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"我的结果：{new Solution().StrStr("sadbutsad","sad")}");
            Console.WriteLine($"正确结果：{"sadbutsad".IndexOf("sad", 0)}");
            Console.WriteLine($"我的结果：{new Solution().StrStr("leetcode", "leeto")}");
            Console.WriteLine($"正确结果：{"leetcode".IndexOf("leeto", 0)}");
            Console.WriteLine($"我的结果：{new Solution().StrStr("aaa", "a")}");
            Console.WriteLine($"正确结果：{"aaa".IndexOf("a", 0)}");
            Console.WriteLine($"我的结果：{new Solution().StrStr("aaa", "aaaa")}");
            Console.WriteLine($"正确结果：{"aaa".IndexOf("aaaa", 0)}");
            Console.WriteLine($"我的结果：{new Solution().StrStr("mississippi", "issip")}");
            Console.WriteLine($"正确结果：{"mississippi".IndexOf("issip", 0)}");
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var start = -1;

            if (haystack.Length >= needle.Length)
            {
                for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        start = i;
                        break;
                    }
                }
            }

            return start;
        }
    }
}