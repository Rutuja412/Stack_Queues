using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueues_Problems
{
    internal class LinkedListQueue
    {

        public Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine(" {0} deserted from Queue", temp.data);
        }

    }
}
