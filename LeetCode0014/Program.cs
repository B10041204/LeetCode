namespace LeetCode0014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[]{ "flower","flow","flight"}));
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result =string.Empty;
            if(strs is not null)
            {
                result= strs[0];

                for (int i = 1; i < strs.Length; i++)
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (j < strs[i].Length)
                        {
                            if (strs[i][j] != result[j])
                            {
                                result = strs[i][0..j];
                                break;
                            }
                        }
                        else
                        {
                            result = strs[i];
                        }
                    }
                }
            }
            return result;
        }
    }
}