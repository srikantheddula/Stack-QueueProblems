using System;

namespace StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);    // adding values to the Queue
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
