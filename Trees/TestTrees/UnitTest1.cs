using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TestTrees
{
    public class UnitTest1
    {
        //Trees Implementation
        [Fact]
        public void TestEmptyTree()
        {
            BinaryTree tree = new BinaryTree();
            Assert.NotNull(tree);
            Assert.Null(tree.Root);
        }

        [Fact]
        public void TestSingleNodeTree()
        {
            BinaryTree tree = new BinaryTree(new Node(10));
            Assert.Equal(10, tree.Root.value);
        }

        [Fact]
        public void TestAddNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10); //Root
            tree.Add(12); //Should be Right
            tree.Add(8);  //Should be Left

            List<int> list = new List<int>();
            list.Add(10); //Root
            list.Add(8);  //Left
            list.Add(12); //Right
            Assert.Equal(list, tree.PreOrder(tree));
        }

        [Fact]
        public void TestPreOrder()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10); //Root
            tree.Add(12); //more than Root
            tree.Add(8);  //less than Root
            tree.Add(1);  //less than 8
            tree.Add(25); //more than 12
            tree.Add(1);  //equal to 1: Left

            List<int> list = new List<int>();
            // PreOreder should be: Root Left Right
            list.Add(10); 
            list.Add(8);  
            list.Add(1);
            list.Add(1);
            list.Add(12); 
            list.Add(25); 
            Assert.Equal(list, tree.PreOrder(tree));
        }

        [Fact]
        public void TestInOrder()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10); //Root
            tree.Add(12); //more than Root
            tree.Add(8);  //less than Root
            tree.Add(1);  //less than 8
            tree.Add(25); //more than 12

            List<int> list = new List<int>();
            // InOreder should be: Left Root Right
            list.Add(1);
            list.Add(8);
            list.Add(10);
            list.Add(12);
            list.Add(25);
            Assert.Equal(list, tree.InOrder(tree));
        }

        [Fact]
        public void TestPostOrder()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10); //Root
            tree.Add(12); //more than Root
            tree.Add(8);  //less than Root
            tree.Add(1);  //less than 8
            tree.Add(25); //more than 12

            List<int> list = new List<int>();
            // PostOreder should be: Left Right Root
            list.Add(1);
            list.Add(8);
            list.Add(25);
            list.Add(12);
            list.Add(10);
            Assert.Equal(list, tree.PostOrder(tree));
        }

        [Fact]
        public void TestTreeContain()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(10);

            Assert.True(tree.Contains(10));
            Assert.False(tree.Contains(12));
        }
    }
}
