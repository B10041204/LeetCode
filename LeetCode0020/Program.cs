using System;

namespace LeetCode0020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsValid("(]"));
            Console.WriteLine(new Solution().IsValid("()[]{}"));
            Console.WriteLine(new Solution().IsValid("{[]}"));
            Console.WriteLine(new Solution().IsValid("[({(())}[()])]"));
            Console.WriteLine(new Solution().IsValid("([)]"));
            Console.WriteLine(new Solution().IsValid("(){}}{"));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var key = new List<char>() { '(', ')', '{', '}', '[', ']' };
            var value = new List<short>() { 1, -1, 2, -2, 3, -3 };
            var history = new Stack<int>();
            var current = 0;
            var pre = int.MinValue;
            history.Push(current);
            for (int i = 0; i < s.Length; i++)
            {
                current += value[key.IndexOf(s[i])];
                if (current > pre || !history.Contains(current))
                {
                    history.Push(current);
                }
                else
                {
                    history.Pop();
                    if (current != history.First())
                    {
                        return false;
                    }
                }
                pre = current;
            }
            if (history.Count > 1)
            {
                return false;
            }
            return true;
        }
    }
}