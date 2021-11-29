using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("--------------------");
            

            int temp;
            for(int i = 0; i < x; i++)
            {
                for(int j=0; j < x - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }


            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(a[i]);
               
            }
        }
    }
}
