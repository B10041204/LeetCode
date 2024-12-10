using System.Reflection.Metadata.Ecma335;

namespace LeetCode0186
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            new Solution().ReverseWords(new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' });
            //new Solution().ReverseWords(new char[] { 'a' });
            //new Solution().ReverseWords(new char[] { 'h', 'i' });
        }
    }
    public class Solution
    {
        /**
         * 输入：s = ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
         * 输出：["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]
         
         * 输入：s = ["a"]
         * 输出：["a"]
         */
        public void ReverseWords(char[] s)
        {
            var index = 0;

            while (index < s.Length - 1)
            {
                var end = s.Length - 1;

                while (end > 0 && s[end] != ' ')
                {
                    end--;
                }
                if (index < end)
                {
                    var alphabet = s[index..end];

                    for (int i = index; i < s.Length - end + index - 1; i++)
                    {
                        s[i] = s[end + i - index + 1];
                    }

                    s[s.Length - end + index - 1] = ' ';

                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        s[s.Length - end + index + i] = alphabet[i];
                    }

                    index = s.Length - end + index;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(string.Join("", s));
        }
    }
}