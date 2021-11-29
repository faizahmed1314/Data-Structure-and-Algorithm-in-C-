using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Enter the number of elements you want to add in the array?");
            string inputNumber = Console.ReadLine();
            int n = int.Parse(inputNumber);

            Console.WriteLine("\n Enter the Array Element \n");

            for(int i=0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                a[i] = int.Parse(numbers);


            }

            Console.WriteLine("Enter the search element" );
            string searchNumber = Console.ReadLine();
            int searchNumberInt = int.Parse(searchNumber);

            for (int i = 0; i < n; i++)
            {
                if (searchNumberInt == a[i])
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Search Successfull");
                    Console.WriteLine("Element {0} found at location {1}", searchNumberInt, i+1);

                }

            }
            Console.WriteLine("Search unsuccessfull");

            

        }
    }
}
