namespace LeetCode0017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LetterCombinations("23"));
            Console.WriteLine("Hello, World!");
        }

    }
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result=new List<string>();
            var dict = new Dictionary<char, List<char>>()
            {
                { '2', new List<char>() {'a','b','c' } },
                { '3', new List<char>() {'d','e','f' } },
                { '4', new List<char>() {'g','h','i' } },
                { '5', new List<char>() {'j','k','l' } },
                { '6', new List<char>() {'m','n','o' } },
                { '7', new List<char>() {'p','q','r','s'} },
                { '8', new List<char>() {'t','u','v'} },
                { '9', new List<char>() {'w','x','y','z' } }
            };
            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = 0; j < dict[digits[i]].Count; j++)
                {

                }
            }
        }

    }
}