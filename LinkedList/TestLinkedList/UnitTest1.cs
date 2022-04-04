using System;
using Xunit;
using linked_list;

namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddToEnd()
        {
            LinkedList list = new();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            list.Append("4");
            Assert.Equal("[3] -> [2] -> [1] -> [4] -> NULL",list.ToString());
        }

        [Fact]
        public void TestAddMultipleToEnd()
        {
            LinkedList list = new();
            list.Append("1");
            list.Append("2");
            list.Append("3");
            list.Append("4");
            Assert.Equal("[1] -> [2] -> [3] -> [4] -> NULL", list.ToString());
        }

        [Fact]
        public void TestInsertBeforeMiddle()
        {
            LinkedList list = new();
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            list.InsertBefore("2", "4");
            Assert.Equal("[1] -> [4] -> [2] -> [3] -> NULL", list.ToString());
        }

        [Fact]
        public void TestInserBeforeFirst()
        {
            LinkedList list = new();
            list.Insert("1");
            list.InsertBefore("1", "4");
            Assert.Equal("[4] -> [1] -> NULL", list.ToString());
        }

        [Fact]
        public void TestInsertAfterMiddle()
        {
            LinkedList list = new();
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            list.InsertAfter("2", "4");
            Assert.Equal("[1] -> [2] -> [4] -> [3] -> NULL", list.ToString());
        }

        [Fact]
        public void TestInsertAfterLast()
        {
            LinkedList list = new();
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            list.InsertAfter("3", "4");
            Assert.Equal("[1] -> [2] -> [3] -> [4] -> NULL", list.ToString());
        }

        [Fact]
        public void TestKthFromEnd()
        {
            LinkedList list = new();
            list.Insert("4");
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            list.Insert("0");
            //Here is this Linked List
            //"[0] -> [1] -> [2] -> [3] -> [4] -> NULL"

            //Where k is greater than the length of the linked list
            Assert.Equal("Exception", list.KthFromEnd(6));

            //Where k and the length of the list are the same
            Assert.Equal("Exception", list.KthFromEnd(5));

            //Where we want the First Node value
            Assert.Equal("0", list.KthFromEnd(4));

            //Where k is not a positive integer
            Assert.Equal("Exception", list.KthFromEnd(-2));

            //�Happy Path� where k is not at the end, but somewhere in the middle of the linked list
            Assert.Equal("3", list.KthFromEnd(1));
        }

        [Fact]
        public void TestKthFromEnd2()
        {
            LinkedList list = new();
            list.Insert("1");
            //Here is this Linked List
            //"[1] -> NULL"

            //Where the linked list is of a size 1
            Assert.Equal("1", list.KthFromEnd(0));
        }
    }
}