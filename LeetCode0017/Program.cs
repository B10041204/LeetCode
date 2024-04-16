using System.Collections;

namespace LeetCode0017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LetterCombinations("237"));
            Console.WriteLine("Hello, World!");
        }

    }
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new Queue<string>();
            var dict = new Dictionary<string, List<string>>()
            {
                { "2", new List<string>() {"a","b","c" } },
                { "3", new List<string>() {"d","e","f" } },
                { "4", new List<string>() {"g","h","i" } },
                { "5", new List<string>() {"j","k","l" } },
                { "6", new List<string>() {"m","n","o" } },
                { "7", new List<string>() {"p","q","r","s"} },
                { "8", new List<string>() {"t","u","v"} },
                { "9", new List<string>() {"w","x","y","z" } }
            };
            var totalCount = 1;
            var preCount = 1;
            var current = 0;
            for (int k = 0; k < digits.Length; k++)
            {
                var count = dict[digits[k].ToString()].Count();
                totalCount *= count;

                var pre = preCount == 1 ? string.Empty : result.Dequeue();

                while (current < totalCount)
                {
                    if (preCount != 1 && current > 0 && current % count == 0)
                    {
                        pre = result.Dequeue();
                    }
                    var mode = current % count;
                    result.Enqueue($"{pre}{dict[digits[k].ToString()][mode]}");
                    current++;
                }
                preCount = count;
                current = 0;
            }
            return result.ToList();
        }
    }
}