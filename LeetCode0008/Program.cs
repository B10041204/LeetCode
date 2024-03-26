namespace LeetCode0008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MyAtoi("  +  413"));
            Console.WriteLine(new Solution().MyAtoi(" - 4193 with words"));
            Console.WriteLine(new Solution().MyAtoi("Hello, World!"));
            Console.WriteLine(new Solution().MyAtoi("-42"));
            Console.WriteLine(new Solution().MyAtoi("+-42"));
            Console.WriteLine(new Solution().MyAtoi("21474836460"));
            Console.WriteLine(new Solution().MyAtoi("-2147483649"));
            Console.WriteLine(new Solution().MyAtoi("0000000000012345678"));
            Console.WriteLine(new Solution().MyAtoi("-000000000000001"));
            Console.WriteLine(new Solution().MyAtoi("   +0 123"));
            Console.WriteLine(new Solution().MyAtoi("words and 987"));
            Console.WriteLine(new Solution().MyAtoi("3.1415926"));
            Console.WriteLine(new Solution().MyAtoi("-0012a42"));
            Console.WriteLine(new Solution().MyAtoi("-5-"));
            Console.WriteLine(new Solution().MyAtoi("123-"));
            Console.WriteLine(new Solution().MyAtoi("21474836++"));


        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            var arr = new List<char>();
            var total = s.TrimEnd(' ').Split(new char[] { ' ' }).ToList();
            var other = new List<char>();
            foreach (var item in total)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (other.Count > 0)
                    {
                        break;
                    }
                    switch (item[i])
                    {
                        case '-':
                        case '+':
                            if (arr.FindAll(i => i == 43 || i == 45).Count() > 1)
                            {
                                other.Add(item[i]);
                            }
                            else
                            {
                                arr.Add(item[i]);
                            }
                            break;
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '.':
                            arr.Add(item[i]);
                            break;
                        default:
                            other.Add(item[i]);
                            break;
                    }
                }
                if (arr.Where(i => i >= 48 && i <= 57).Count() > 0 ||
                    arr.Where(i => i == 43 || i == 45).Count() >= 2 ||
                     (other.Count > 0 && other.Where(i => i < 43 || i == 44 || (i > 45 && i < 48) || i > 57).Count() == other.Count()))
                {
                    break;
                }
            }
            var symbols = arr.Where(i => i == 43 || i == 45);
            if (symbols.Count() >= 1)
            {
                var index = new List<int>();
                for (int i = 0; i < arr.Count(); i++)
                {
                    if ((arr[i] == 43 || arr[i] == 45))
                    {
                        index.Add(i);
                    }
                }
                var length = index.Where(i => i != 0).FirstOrDefault();
                arr = arr.GetRange(0, length==0?arr.Count():length);
            }
            var str = string.Join("", arr);
            //整数判断
            if (str.IndexOf('.') >= 0)
            {
                str = str.Substring(0, str.IndexOf("."));
            }

            if (str.IndexOf("-") >= 0)
            {
                str = str.Substring(1).TrimStart('0');
                if (str.Length > int.MinValue.ToString().Length - 1)
                {
                    return int.MinValue;
                }
                else if (str.Length == int.MinValue.ToString().Length - 1)
                {
                    if (int.TryParse($"-{str}", out int result))
                    {
                        return result;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    if (int.TryParse($"-{str}", out int result))
                    {
                        return result;
                    }
                    else
                    {
                        return default(int);
                    }
                }
            }
            else
            {
                str = str.TrimStart('0');
                if (str.Length > int.MaxValue.ToString().Length)
                {
                    return int.MaxValue;
                }
                else if (str.Length == int.MaxValue.ToString().Length)
                {
                    if (int.TryParse(str, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        return int.MaxValue;
                    }
                }
                else
                {
                    if (int.TryParse(str, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        return default(int);
                    }
                }
            }
        }
    }
}