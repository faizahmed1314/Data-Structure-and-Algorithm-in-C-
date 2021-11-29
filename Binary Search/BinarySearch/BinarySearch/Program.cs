using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] numbers = new int[] { 1, 2, 5, 8, 9, 12, 14, 18, 19, 50, 67, 89, 90, 98 };

            getSearchNumber(numbers, 1);

        }

        public static int getSearchNumber(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (array[mid] == number)
                {
                    Console.WriteLine("element {0} found in {1} index",number, mid);
                    return mid;
                }

                if (array[mid] > number)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
