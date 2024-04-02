namespace LeetCode0013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));
            Console.WriteLine(new Solution().RomanToInt("LVIII"));
            Console.WriteLine(new Solution().RomanToInt("III"));
            Console.WriteLine(new Solution().RomanToInt("IV"));
            Console.WriteLine(new Solution().RomanToInt("IX")); 
            Console.WriteLine(new Solution().RomanToInt("XLIX"));
            Console.WriteLine(new Solution().RomanToInt("CMXCIX"));
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            var current = default(int);
            var mode = new char[7] { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            var nums = new ushort[7] { 1000, 500, 100, 50, 10, 5, 1 };
            var values = new ushort[s.Length];
            var result = 0;
            var flag = true;

            while (current < s.Length)
            {
                for (var i = 0; i < mode.Length; i++)
                {
                    if (s[current] == mode[i])
                    {
                        values[current] = nums[i];
                        break;
                    }
                }
                if (current>= 1)
                {
                    switch ($"{s[current - 1]}{s[current]}")
                    {
                        case "IV":
                            result += 4;
                            flag = false;
                            break;
                        case "IX":
                            result += 9;
                            flag = false;
                            break;
                        case "XL":
                            result += 40;
                            flag = false;
                            break;
                        case "XC":
                            result += 90;
                            flag = false;
                            break;
                        case "CD":
                            result += 400;
                            flag = false;
                            break;
                        case "CM":
                            result += 900;
                            flag = false;
                            break;
                        default:
                            if (flag)
                            {
                                result += values[current - 1];
                            }
                            flag = true;
                            break;
                    }
                }
                current++;
            }
            if (flag)
            {
                result += values[s.Length - 1];
            }
            return result;
        }
    }
}