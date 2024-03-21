using System.Reflection.Metadata.Ecma335;

namespace LeetCode0006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().Convert("A", 2));
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            var result = string.Empty;
            if (numRows > 1)
            {
                var num = 2 * numRows - 2;
                var array = new char[numRows][];
                var colums = new int[numRows];
                var current = new int[numRows];
                for (int i = 0; i < s.Length; i++)
                {
                    var remainder = i % num;
                    if (remainder >= numRows)
                    {
                        remainder = num - remainder;
                    }
                    colums[remainder]++;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    var remainder = i % num;
                    if (remainder >= numRows)
                    {
                        remainder = num - remainder;
                    }
                    if (array[remainder] is null)
                    {
                        array[remainder] = new char[colums[remainder]];
                    }
                    array[remainder][current[remainder]] = s[i];
                    current[remainder]++;
                }
                for (int i = 0; i < numRows; i++)
                {
                    if (array[i] is not null && array[i].Length > 0)
                    {
                        result = result + string.Join("", array[i]);
                    }
                }
            }
            else
            {
                result = s;
            }
            return result;
        }
    }
}