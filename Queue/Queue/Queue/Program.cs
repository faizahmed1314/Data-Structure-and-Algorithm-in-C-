using System;

namespace Queue
{
    class Program
    {
        private const int Capacity = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] queue = new int[Capacity];
            int front = 0, rear = -1, totalItem = 0;

            dequeue();
            enqueue(4);
            enqueue(6);
            enqueue(5);
            enqueue(61);
            enqueue(43);
            dequeue();
            enqueue(83);
            printValue();


            void printValue()
            {
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }

            bool IsFull()
            {
                if (totalItem == Capacity)
                {
                    return true;
                }
                return false;
            }

            bool IsEmpty()
            {
                if (totalItem == 0)
                {
                    return true;
                }
                return false;
            }

            void enqueue(int item)
            {
                if (IsFull())
                {
                    Console.WriteLine("Queue is full");
                }
              
                rear = (rear + 1) % Capacity;
                queue[rear] = item;
                totalItem++;

            }

            int dequeue()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty");
                }

                int frontItem = queue[front];

                front = (front + 1) % Capacity;
                totalItem--;


                return frontItem;
            }


        }
    }
}
