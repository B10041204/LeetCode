namespace LeetCode0205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(new Solution().IsIsomorphic("foo", "bar"));
            //Console.WriteLine(new Solution().IsIsomorphic("egg", "add"));
            Console.WriteLine(new Solution().IsIsomorphic("paper", "title"));
        }
    }
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    dict.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }
}