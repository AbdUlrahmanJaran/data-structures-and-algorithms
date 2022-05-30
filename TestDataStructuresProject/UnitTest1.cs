using System;
using Xunit;
using data_structures_project;

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
    }
}
