using System;

namespace stack
{
    class Program
    {
        
        private const int  capacity=5;
        
        static void Main(string[] args)
        {
            int[] stack = new int[capacity];
            int top = -1;

            push(1);
            push(3);
            push(5);
            int m1=peek();
            Console.WriteLine("Item peeked " + m1);

            push(7);
            push(10);
            int n1 = pop();
            Console.WriteLine("Item poped "+ n1);
            Console.WriteLine( n1);
            push(25);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            void push(int item)
            {
                if (top < capacity - 1)
                {
                    top = top + 1;
                    stack[top] = item;
                    Console.WriteLine("Item pushed successfully");
                }
                else
                {
                    Console.WriteLine("Stack is full");
                }
            }

            int pop()
            {
                if (top >= 0)
                {
                    int val = stack[top];
                    top = top - 1;
                    return val;
                }
                Console.WriteLine("Stack is empty");
                return -1;
            }

            int peek()
            {
                if (top >= 0)
                {
                    return stack[top];
                }
                return -1;
            }
        }
     
    }
}
