namespace LeetCode0003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(new Solution().LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(new Solution().LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(new Solution().LengthOfLongestSubstring("aab"));
            Console.WriteLine(new Solution().LengthOfLongestSubstring("dvdf"));
        }
    }

    /*
     * 给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串的长度。
     * 
     * 示例 1:
     * 
     * 输入: s = "abcabcbb"
     * 输出: 3 
     * 解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
     * 
     * 示例 2:
     * 
     * 输入: s = "bbbbb"
     * 输出: 1
     * 解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
     * 
     * 示例 3:
     * 
     * 输入: s = "pwwkew"
     * 输出: 3
     * 解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     * 
     * 请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
     */
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var chars = s.ToCharArray();
            var prev = string.Empty;
            var max = 0;
            foreach (char c in chars)
            {
                var index = prev.LastIndexOf(c);
                if (index > -1)
                {
                    max=prev.Length>max? prev.Length : max;
                    prev = prev.Substring(index + 1 >= prev.Length ? index : index + 1);
                    if (!prev.Contains(c))
                    {
                        prev = prev + c;
                    }
                }
                else
                {
                    prev = prev + c;
                }
            }
            max = prev.Length > max ? prev.Length : max;
            return max;
        }
    }
}