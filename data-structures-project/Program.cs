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

            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.QuickSort(arr, 0, arr.Length-1)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(reverseSorted)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(fewUniques)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(nearlySorted)));

            HashTable hash = new HashTable();
            hash.Set("Goku", "Dragon Ball");
            hash.Set("Luffy", "One Piece");
            Console.WriteLine(hash.Get("Goku"));
            Console.WriteLine(hash.Get("Luffy"));
            Console.WriteLine(hash.Get("s"));
            Console.WriteLine(hash.Contains("Luffy"));
            Console.WriteLine(hash.Contains("s"));

            Console.WriteLine("{0}", String.Join(", ", hash.Keys()));
            //string lowers = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            //string[] words = lowers.Split(' ', ',');
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}
            Console.WriteLine(HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
            Console.WriteLine(HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
            Console.WriteLine(HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));
        }
    }
}
