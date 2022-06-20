using System;
using Xunit;
using data_structures_project;
using System.Collections.Generic;

namespace TestDataStructuresProject
{
    public class UnitTest1
    {
        //Stack Tests
        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack();
            stack.Push("1");
            Assert.Equal("[1] -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPushMultiple()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            Assert.Equal("[3] -> [2] -> [1] -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Pop(); //this will pop "2"
            Assert.Equal("[1] -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPopMultiple()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Pop(); //this will pop "2"
            stack.Pop(); //this will pop "1"
            Assert.Equal("The Stack is Empty", stack.ToString());
        }

        [Fact]
        public void TestStackPeek()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            Assert.Equal("2", stack.Peek());
        }

        [Fact]
        public void TestEmptyStack()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestStackExceptions()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(stack.Peek);
            Assert.Throws<Exception>(stack.Pop);
        }

        //Queue Tests
        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            Assert.Equal("[1] -> NULL", queue.ToString());
        }

        [Fact]
        public void TestEnqueueMultiple()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            Assert.Equal("[1] -> [2] -> [3] -> NULL", queue.ToString());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Dequeue(); //this will dequeue "1"
            Assert.Equal("[2] -> NULL", queue.ToString());
        }

        [Fact]
        public void TestQueuePeek()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            Assert.Equal("1", queue.Peek());
        }

        [Fact]
        public void TestDequeueMultiple()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Dequeue(); //this will dequeue "1"
            queue.Dequeue(); //this will dequeue "2"
            Assert.Equal("The Queue is Empty", queue.ToString());
        }

        [Fact]
        public void TestEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestQueueExceptions()
        {
            Queue queue = new Queue();
            Assert.Throws<Exception>(queue.Peek);
            Assert.Throws<Exception>(queue.Dequeue);
        }

        //AnimalShelter Tests
        [Fact]
        public void TestAnimalShelterCat()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(cat2);
            Assert.Equal("Cat 1", animalShelter.Dequeue("cat"));
        }

        [Fact]
        public void TestAnimalShelterDog()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog1 = new Dog();
            Animal dog2 = new Dog();
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            Assert.Equal("Dog 1", animalShelter.Dequeue("dog"));
        }

        [Fact]
        public void TestAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog();
            Animal cat = new Cat();
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            Assert.Equal("Cat 1", animalShelter.Dequeue("cat"));
        }

        [Fact]
        public void TestAnimalShelterNull()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog();
            Animal cat = new Cat();
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            Assert.Null(animalShelter.Dequeue("t"));
        }

        //ValidateBrackets Tests
        [Fact]
        public void TestValidateBracketsTrue()
        {
            Assert.True(Stack.ValidateBrackets("{}"));
            Assert.True(Stack.ValidateBrackets("{}(){}"));
            Assert.True(Stack.ValidateBrackets("(){}[[]]"));
        }
        [Fact]
        public void TestValidateBracketsFalse()
        {
            Assert.False(Stack.ValidateBrackets("[({}]"));
            Assert.False(Stack.ValidateBrackets("(]("));
            Assert.False(Stack.ValidateBrackets("{(})"));
        }

        [Fact]
        public void TestValidateBracketsExtraChars()
        {
            Assert.True(Stack.ValidateBrackets("()[[Extra Characters]]"));
            Assert.True(Stack.ValidateBrackets("{}{Code}[Fellows](())"));
            Assert.False(Stack.ValidateBrackets("[{Word]}"));
        }
        
        //Test PsudoQueue
        [Fact]
        public void TestPseudoQueueEnqueue()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue("5");
            pseudoQueue.Enqueue("10");
            pseudoQueue.Enqueue("15");
            pseudoQueue.Enqueue("20");
            Assert.Equal("5", pseudoQueue.Peek());
        }

        [Fact]
        public void TestPseudoQueueDequeue()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue("5");
            pseudoQueue.Enqueue("10");
            pseudoQueue.Enqueue("15");
            pseudoQueue.Enqueue("20");
            pseudoQueue.Dequeue();
            Assert.Equal("10", pseudoQueue.Peek());
        }

        //InsertionSort Test
        [Fact]
        public void TestInsertionSortNull()
        {
            int[] arr = { };
            Assert.Null(SortingAlgorithms.InsertionSort(arr));
        }

        [Fact]
        public void TestInsertionSortSortedArray()
        {
            int[] arr = { 1, 2, 5, 22, 100 };
            Assert.Equal(arr, SortingAlgorithms.InsertionSort(arr));
        }

        [Fact]
        public void TestInsertionSortReversedArray()
        {
            int[] arr = { 20, 18, 12, 8, 5, -2 };
            int[] sortedArray = { -2, 5, 8, 12, 18, 20 };
            Assert.Equal(sortedArray, SortingAlgorithms.InsertionSort(arr));
        }

        //MergeSort Test
        [Fact]
        public void TestMergeSortNull()
        {
            int[] arr = { };
            Assert.Null(SortingAlgorithms.MergeSort(arr));
        }

        [Fact]
        public void TestMergeSortOddArray()
        {
            int[] arr = { 20, 18, 12, 8, 5 };
            int[] sortedArray = { 5, 8, 12, 18, 20 };
            Assert.Equal(sortedArray, SortingAlgorithms.MergeSort(arr));
        }

        [Fact]
        public void TestMergeSortSortedArray()
        {
            int[] arr = { 1, 2, 5, 22, 100 };
            Assert.Equal(arr, SortingAlgorithms.MergeSort(arr));
        }

        //QuickSort Test
        [Fact]
        public void TestQuickSortNull()
        {
            int[] arr = { };
            Assert.Null(SortingAlgorithms.QuickSort(arr, 0, arr.Length - 1));
        }

        [Fact]
        public void TestQuickSortOddArray()
        {
            int[] arr = { 5, 12, 7, 5, 5, 7 };
            int[] sortedArray = { 5, 5, 5, 7, 7, 12 };
            Assert.Equal(sortedArray, SortingAlgorithms.QuickSort(arr, 0, arr.Length - 1));
        }

        [Fact]
        public void TestMergeSortReversedArray()
        {
            int[] arr = { 20, 18, 12, 8, 5, -2 };
            int[] sortedArray = { -2, 5, 8, 12, 18, 20 };
            Assert.Equal(sortedArray, SortingAlgorithms.QuickSort(arr, 0, arr.Length - 1));
        }

        //HashTableTest
        [Fact]
        public void TestHashTableSet()
        { 
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");

            Assert.True(hashTable.Contains("Luffy"));
        }

        [Fact]
        public void TestHashTableGet()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");

            Assert.Equal("One Piece", hashTable.Get("Luffy"));
        }

        [Fact]
        public void TestHashTableNull()
        {
            HashTable hashTable = new HashTable();

            Assert.Null(hashTable.Get("Goku"));
        }

        [Fact]
        public void TestHashTableList()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("Goku", "Dragon Ball");
            hashTable.Set("Gon", "Hunter X Hunter");

            List<string> list = new List<string>();
            list.Add("Gon");
            list.Add("Goku");
            list.Add("Luffy");

            Assert.Equal(list, hashTable.Keys());
        }

        [Fact]
        public void TestHashTableCollision()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("yffuL", "Straw Hat");

            Assert.Equal(hashTable.Hash("Luffy"), hashTable.Hash("yffuL"));
            Assert.True(hashTable.Contains("Luffy"));
            Assert.True(hashTable.Contains("yffuL"));
        }

        [Fact]
        public void TestHashTableCollisionValue()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("yffuL", "Straw Hat");

            Assert.Equal("Straw Hat", hashTable.Get("yffuL"));
        }

        [Fact]
        public void TestHashTableHashInRange()
        {
            HashTable hashTable = new HashTable();

            Assert.True(hashTable.Hash("ABCDEFGHIJKLMNOP") > 0);
            Assert.True(hashTable.Hash("ABCDEFGHIJKLMNOP") < 1024);
        }

        //RepeatedWordTest
        [Fact]
        public void TestRepeatedWordSimple()
        {
            Assert.Equal("a",HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
        }

        [Fact]
        public void TestRepeatedWordSmallLetters()
        {
            Assert.Equal("it", HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
        }

        [Fact]
        public void TestRepeatedWordComa()
        {
            Assert.Equal("summer", HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));
        }

        //LeftJoinTest
        [Fact]
        public void TestLeftJoinFoundAll()
        {
            HashTable synonyms = new HashTable();
            synonyms.Set("diligent", "employed");
            synonyms.Set("fond", "enamored");
            synonyms.Set("guide", "usher");

            HashTable antonyms = new HashTable();
            antonyms.Set("diligent", "idle");
            antonyms.Set("fond", "averse");
            antonyms.Set("guide", "follow");

            List<string> result = new List<string>();
            result.Add("(diligent , employed , idle)");
            result.Add("(fond , enamored , averse)");
            result.Add("(guide , usher , follow)");

            Assert.Equal(result, HashTable.LeftJoin(synonyms, antonyms));
        }

        [Fact]
        public void TestLeftJoinNulls()
        {
            HashTable synonyms = new HashTable();
            synonyms.Set("diligent", "employed");
            synonyms.Set("fond", "enamored");
            synonyms.Set("guide", "usher");
            synonyms.Set("outfit", "garb");
            synonyms.Set("wrath", "anger");

            HashTable antonyms = new HashTable();
            antonyms.Set("diligent", "idle");
            antonyms.Set("fond", "averse");
            antonyms.Set("guide", "follow");
            antonyms.Set("flow", "jam");
            antonyms.Set("wrath", "delight");

            List<string> result = new List<string>();
            result.Add("(wrath , anger , delight)");
            result.Add("(outfit , garb , NULL)");
            result.Add("(diligent , employed , idle)");
            result.Add("(fond , enamored , averse)");
            result.Add("(guide , usher , follow)");

            Assert.Equal(result, HashTable.LeftJoin(synonyms, antonyms));
        }

        [Fact]
        public void TestLeftJoinSameValue()
        {
            HashTable Anime = new HashTable();
            Anime.Set("One Piece", "Luffy");
            Anime.Set("Hunter X Hunter", "Gon");
            Anime.Set("Dragon Ball", "Goku");

            HashTable Rating = new HashTable();
            Rating.Set("One Piece", "Better");
            Rating.Set("Hunter X Hunter", "Best");
            Rating.Set("Dragon Ball", "Goku");

            List<string> result = new List<string>();
            result.Add("(One Piece , Luffy , Better)");
            result.Add("(Dragon Ball , Goku , Goku)");
            result.Add("(Hunter X Hunter , Gon , Best)");

            Assert.Equal(result, HashTable.LeftJoin(Anime, Rating));
        }

        //GraphTest
        [Fact]
        public void TestGraphAddNode()
        { 
            Graph graph = new Graph();
            graph.AddNode("45");

            Assert.NotNull(graph.GetNodes());
        }

        [Fact]
        public void TestGraphAddEdge()
        {
            Graph graph = new Graph();
            graph.AddNode("45");
            graph.AddNode("22");

            Node node1 = new Node("45");
            Node node2 = new Node("22");
            graph.AddEdge(node1 , node2);

            Assert.NotNull(graph.GetNeighbors(node1));
        }

        [Fact]
        public void TestGraphGetNodes()
        {
            Graph graph = new Graph();
            graph.AddNode("45");
            graph.AddNode("22");

            List<string> test = new List<string>();
            test.Add("45");
            test.Add("22");

            List<string> nodesValues = new List<string>();
            foreach (var item in graph.GetNodes())
                nodesValues.Add(item.value);

            Assert.Equal(test, nodesValues);
        }

        [Fact]
        public void TestGraphGetNeighbors()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");

            Node node1 = new Node("A");
            Node node2 = new Node("E");
            Node node3 = new Node("C");
            Node node4 = new Node("D");


            graph.AddEdge(node1, node2);
            graph.AddEdge(node3, node1);
            graph.AddEdge(node4, node1);

            List<Node> result = new List<Node>();
            result.Add(node2);
            result.Add(node3);
            result.Add(node4);

            Assert.Equal(result, graph.GetNeighbors(node1));
        }

        [Fact]
        public void TestGraphSize()
        {
            Graph graph = new Graph();
            graph.AddNode("45");
            graph.AddNode("22");
            graph.AddNode("7");

            Assert.Equal(3, graph.Size());
        }

        [Fact]
        public void TestGraphNodeEdge()
        {
            Graph graph = new Graph();
            graph.AddNode("A");

            Node node = new Node("A");
            graph.AddEdge(node , node);

            Assert.NotNull(graph.GetNodes());
            Assert.Null(graph.GetNeighbors(node));
        }

        [Fact]
        public void TestGraphNull()
        {
            Graph graph = new Graph();

            Assert.Null(graph.GetNodes());
        }
    }
}
