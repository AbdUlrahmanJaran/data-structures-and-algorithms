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
    }
}
