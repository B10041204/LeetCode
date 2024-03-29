namespace LeetCode0012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Solution().IntToRoman(1));
            //Console.WriteLine(new Solution().IntToRoman(3));
            //Console.WriteLine(new Solution().IntToRoman(4));
            //Console.WriteLine(new Solution().IntToRoman(5));
            //Console.WriteLine(new Solution().IntToRoman(8));
            //Console.WriteLine(new Solution().IntToRoman(9));
            //Console.WriteLine(new Solution().IntToRoman(10));
            //Console.WriteLine(new Solution().IntToRoman(11));
            //Console.WriteLine(new Solution().IntToRoman(15));
            //Console.WriteLine(new Solution().IntToRoman(16));
            //Console.WriteLine(new Solution().IntToRoman(58));
            //Console.WriteLine(new Solution().IntToRoman(148));
            //Console.WriteLine(new Solution().IntToRoman(598));
            //Console.WriteLine(new Solution().IntToRoman(1994));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var orginal = num;
            var array = new List<short>();
            var result = new List<string>();
            //1000,500,100,50,10,5,1
            var mode = new List<char>() { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            var dividend = 1000;
            var index = 0;

            do
            {
                array.Add((short)(num / dividend));
                num = num % dividend;
                dividend = index % 2 == 0 ? dividend / 2 : dividend / 5;
                index++;
            } while (num > 0);

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] > 0)
                {
                    if (array[i] == 2 || array[i] == 3 || (i + 1 < array.Count() && array[i] == 1 && array[i + 1] != 4) || (i + 1 == array.Count() && array[i] != 4))
                    {
                        result.Add(new string(mode[i], array[i]));
                    }
                    else if (i >= 2 && array[i - 1] == 1 && array[i] == 4)
                    {
                        result.Add($"{mode[i]}{mode[i - 2]}");
                    }
                    else if (i >= 1 && array[i - 1] == 0 && array[i] == 4)
                    {
                        result.Add($"{mode[i]}{mode[i - 1]}");
                    }
                }
            }

            return string.Join(string.Empty, result.ToArray());
        }

    }
}