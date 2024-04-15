namespace LeetCode0027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
            Console.WriteLine(new Solution().RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            return QuickSort(nums, val);
        }

        private int QuickSort(int[] arr, int pivot)
        {
            var low = 0;
            var index = low;

            while (low <= arr.Length - 1 && index <= arr.Length - 1)
            {
                if (arr[index] != pivot)
                {
                    Swap(arr, index, low);
                    low++;
                }
                index++;
            }
            return low;
        }

        private void Swap(int[] arr, int i, int j)
        {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}