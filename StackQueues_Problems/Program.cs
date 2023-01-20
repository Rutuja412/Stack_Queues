using System;

namespace StackQueues_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack & Queue Practice Problems");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.Write("\n");
            Console.WriteLine("Sequence of stack after push values are:  ");
            Console.WriteLine("--------------------------------------------");
            linkedListStack.Display();
            Console.WriteLine("--------------------------------------------");
            linkedListStack.Peek();
            Console.Write("\n");

            Console.WriteLine("--------------------------------------------");
            linkedListStack.Pop();
            Console.Write("\n");

            Console.WriteLine("--------------------------------------------");
            linkedListStack.IsEmpty();
            Console.Write("\n");

        }
    }
}
