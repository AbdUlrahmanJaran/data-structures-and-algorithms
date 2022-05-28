using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structures_project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Project");
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

            //PseudoQueue pseudoQueue = new PseudoQueue();
            //pseudoQueue.Enqueue("1");
            //pseudoQueue.Enqueue("2");
            //pseudoQueue.Enqueue("3");
            //pseudoQueue.Enqueue("4");
            //pseudoQueue.Dequeue();

            //AnimalShelter animalShelter = new AnimalShelter();
            //Animal cat = new Cat();
            //animalShelter.Enqueue(new Dog());
            //animalShelter.Enqueue(new Dog());
            //animalShelter.Enqueue(cat);
            //animalShelter.Enqueue(cat);
            //animalShelter.Enqueue(cat);
            //Console.WriteLine(animalShelter.Dequeue("cat"));
            //Console.WriteLine(animalShelter.Dequeue("cat"));
            //Console.WriteLine(animalShelter.Dequeue("dog"));
            //Console.WriteLine(animalShelter.Dequeue("at"));

            //Console.Write(Stack.ValidateBrackets("{ } ()kk){ }"));

            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            //Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.InsertionSort(arr)));
            //Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.InsertionSort(reverseSorted)));
            //Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.InsertionSort(fewUniques)));
            //Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.InsertionSort(nearlySorted)));
            
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(arr)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(reverseSorted)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(fewUniques)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(nearlySorted)));


        }
    }
}
