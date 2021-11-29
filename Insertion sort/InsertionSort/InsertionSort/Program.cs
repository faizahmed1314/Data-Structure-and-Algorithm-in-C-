using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 12, 15, 4, 6, 3, 1 };

            int l = a.Length;

            Console.WriteLine(l);

            int i, j, temp;

            for (i = 1; i < l; i++)
            {
                temp = a[i];
                j = i - 1;
                while(j>=0 && a[j] > temp)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j+1] = temp;
            }

            for(int x=0; x < l; x++)
            {
                Console.WriteLine(a[x]);
            }
        }
    }
}
