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
            Assert.True(Program.ValidateBrackets("{}"));
            Assert.True(Program.ValidateBrackets("{}(){}"));
            Assert.True(Program.ValidateBrackets("(){}[[]]"));
        }
        [Fact]
        public void TestValidateBracketsFalse()
        {
            Assert.False(Program.ValidateBrackets("[({}]"));
            Assert.False(Program.ValidateBrackets("(]("));
            Assert.False(Program.ValidateBrackets("{(})"));
        }

        [Fact]
        public void TestValidateBracketsExtraChars()
        {
            Assert.True(Program.ValidateBrackets("()[[Extra Characters]]"));
            Assert.True(Program.ValidateBrackets("{}{Code}[Fellows](())"));
            Assert.False(Program.ValidateBrackets("[{Word]}"));
        }
    }
}
