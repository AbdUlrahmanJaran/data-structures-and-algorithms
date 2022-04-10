using System;
using Xunit;
using data_structures_project;

namespace TestDataStructuresProject
{
    public class UnitTest1
    {
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
    }
}
