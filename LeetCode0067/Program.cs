using System.Text;

namespace LeetCode0067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new Solution().AddBinary("1010", "1011"));
        }
    }
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var result = new Queue<string>();
            var bigger= a.Length > b.Length ? a : b;
            var smaller= a.Length > b.Length ? b : a;

            var bindex = bigger.Length - 1;
            var sindex=smaller.Length - 1;
            var quotient = default(int);

            while (sindex >= 0)
            {
                var item = Convert.ToInt32(bigger[bindex].ToString()) + Convert.ToInt16(smaller[sindex].ToString()) + quotient;
                quotient = item / 2;
                var resutlItem = item % 2;
                result.Enqueue(resutlItem.ToString());
                bindex--;
                sindex--;
            }
            while (bindex >= 0)
            {
                var item = Convert.ToInt32(bigger[bindex].ToString()) + quotient;
                quotient = item / 2;
                var resutlItem = item % 2;
                result.Enqueue(resutlItem.ToString());
                bindex--;
            }
            if (quotient != 0)
            {
                result.Enqueue(quotient.ToString());
            }

            return string.Join("", result.Reverse());
        }
    }
}