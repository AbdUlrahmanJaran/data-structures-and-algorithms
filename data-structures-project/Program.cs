using System;

namespace data_structures_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Data Structure Project");
            //Stack stack = new Stack();
            //stack.Push("1");
            //stack.Push("2");
            //Console.WriteLine(stack.ToString());
            //stack.Pop();
            //Console.WriteLine(stack.ToString());

            //Queue queue = new Queue();
            //queue.Enqueue("1");
            //queue.Enqueue("2");
            //queue.Enqueue("3");
            //Console.WriteLine(queue.ToString());
            //queue.Dequeue();
            //Console.WriteLine(queue.ToString());

            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue("1");
            pseudoQueue.Enqueue("2");
            pseudoQueue.Enqueue("3");
            pseudoQueue.Enqueue("4");
            pseudoQueue.Dequeue();

        }
    }
}
