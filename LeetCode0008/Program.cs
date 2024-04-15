namespace LeetCode0008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0
            Console.WriteLine(new Solution().MyAtoi("  +  413"));
            //0
            Console.WriteLine(new Solution().MyAtoi(" - 4193 with words"));
            //0
            Console.WriteLine(new Solution().MyAtoi("Hello, World!"));
            //-42
            Console.WriteLine(new Solution().MyAtoi("-42"));
            //0
            Console.WriteLine(new Solution().MyAtoi("+-42"));
            //-20
            Console.WriteLine(new Solution().MyAtoi("21474836460"));
            //2147483647
            Console.WriteLine(new Solution().MyAtoi("-2147483649"));
            //12345678
            Console.WriteLine(new Solution().MyAtoi("0000000000012345678"));
            //-1
            Console.WriteLine(new Solution().MyAtoi("-000000000000001"));
            //0
            Console.WriteLine(new Solution().MyAtoi("   +0 123"));
            //0
            Console.WriteLine(new Solution().MyAtoi("words and 987"));
            //3
            Console.WriteLine(new Solution().MyAtoi("3.1415926"));
            //-12
            Console.WriteLine(new Solution().MyAtoi("-0012a42"));
            //-5
            Console.WriteLine(new Solution().MyAtoi("-5-"));
            //123
            Console.WriteLine(new Solution().MyAtoi("123-"));
            //21474836
            Console.WriteLine(new Solution().MyAtoi("21474836++"));
            //
            Console.WriteLine(new Solution().MyAtoi("-91283472332"));
            //0
            Console.WriteLine(new Solution().MyAtoi("00000-42a1234"));
            //int.MaxValue
            Console.WriteLine(new Solution().MyAtoi("9223372036854775808"));
            //2147483647
            Console.WriteLine(new Solution().MyAtoi("+11191657170"));
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            var index = 0;
            var flag = 0;
            var start = int.MinValue;
            var total = default(long);
            var isContinue = false;
            while (index < s.Length)
            {
                //符号
                if (s[index] == '+' || s[index] == '-')
                {
                    if (flag == 0 && total == default(long) && start == int.MinValue)
                    {
                        flag = s[index] == '+' ? 1 : -1;
                        index++;
                        isContinue = true;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (s[index] != ' ' && (s[index] >= 48 && s[index] <= 57 && start != int.MinValue))
                {
                    total *= 10;
                    if (total < int.MaxValue)
                    {
                        total += s[index] - 48;
                    }
                    else
                    {
                        return (flag == 0 || flag == 1) ? int.MaxValue : int.MinValue;
                    }
                    isContinue = true;
                    index++;
                }
                else if (s[index] == '.')
                {
                    break;
                }
                else if (s[index] >= 48 && s[index] <= 57 && start == int.MinValue)
                {
                    start = index;
                    total += s[index] - 48;
                    index++;
                    isContinue = true;
                }
                else if (s[index] == ' ')
                {
                    if (start != int.MinValue)
                    {
                        break;
                    }
                    if (isContinue)
                    {
                        break;
                    }
                    index++;
                }
                else
                {
                    break;
                }
            }
            var result = total * (flag == 0 ? 1 : flag);
            if (result > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (result < int.MinValue)
            {
                return int.MinValue;
            }
            else
            {
                return (int)result;
            }
        }
    }
}