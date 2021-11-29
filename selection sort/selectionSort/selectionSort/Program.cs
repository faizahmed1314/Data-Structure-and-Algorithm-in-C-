using System;

namespace selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 2, 6, 3, 4 };

            int n = a.Length;
            int index_min;
            int temp;

            for(int i = 0; i < n - 1; i++)
            {
                index_min = i;

                for(int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[index_min])
                    {
                        index_min = j;
                    }
                }

                if (index_min != i)
                {
                    temp = a[i];
                    a[i] = a[index_min];
                    a[index_min] = temp;
                }
            }

            Console.WriteLine("size"+ n);

            for(int x = 0; x < n; x++)
            {
                Console.WriteLine(a[x]);
            }

        }

    }
}
