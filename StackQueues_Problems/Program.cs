using System;

namespace StackQueues_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack & Queue Practice Problems");
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(70);
            //linkedListStack.Push(30);
            //linkedListStack.Push(56);
            //linkedListStack.Display();
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            Console.WriteLine("----------------------------");
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("\n");
            Console.WriteLine("Sequence of queue are: ");
            Console.WriteLine("----------------------------");
            linkedListQueue.Display();
            Console.WriteLine("\n");
            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
            Console.WriteLine("----------------------------");
            linkedListQueue.Display();
            Console.WriteLine("\n");
          

        }
    }
}
