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
            Assert.Equal(list, tree.PreOrder());
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
            Assert.Equal(list, tree.PreOrder());
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
            Assert.Equal(list, tree.InOrder());
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
            Assert.Equal(list, tree.PostOrder());
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

        // Max Tests
        [Fact]
        public void TestTreeMax()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            tree.Root.left = new Node(10);
            tree.Root.right = new Node(19);
            tree.Root.left.left = new Node(180);
            tree.Root.left.right = new Node(1);
            tree.Root.right.left = new Node(3);
            tree.Root.right.right = new Node(99);

            Assert.Equal(180 ,tree.Max());
        }

        [Fact]
        public void TestTreeMaxRoot()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(200);
            tree.Root.left = new Node(10);
            tree.Root.right = new Node(19);
            tree.Root.left.left = new Node(180);
            tree.Root.left.right = new Node(1);
            tree.Root.right.left = new Node(3);
            tree.Root.right.right = new Node(99);

            Assert.Equal(200, tree.Max());
        }

        [Fact]
        public void TestTreeMaxLeaf()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.left = new Node(10);
            tree.Root.right = new Node(19);
            tree.Root.left.left = new Node(180);
            tree.Root.left.right = new Node(1);
            tree.Root.right.left = new Node(3);
            tree.Root.right.right = new Node(200);

            Assert.Equal(200, tree.Max());
        }

        // BreadthFirst Test
        [Fact]
        public void TestBreadthFirst()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(2);
            binaryTree.Root.left = new Node(7);
            binaryTree.Root.right = new Node(5);
            binaryTree.Root.left.left = new Node(2);
            binaryTree.Root.left.right = new Node(6);
            binaryTree.Root.left.right.left = new Node(5);
            binaryTree.Root.left.right.right = new Node(11);
            binaryTree.Root.right.right = new Node(9);
            binaryTree.Root.right.right.left = new Node(4);

            List<int> list = new List<int>();
            // BreadthFirst should be: [2,7,5,2,6,9,5,11,4]
            list.Add(2);
            list.Add(7);
            list.Add(5);
            list.Add(2);
            list.Add(6);
            list.Add(9);
            list.Add(5);
            list.Add(11);
            list.Add(4);

            Assert.Equal(list, BinaryTree.BreadthFirst(binaryTree));
        }

        [Fact]
        public void TestBreadthFirstNull()
        {
            BinaryTree binaryTree = new BinaryTree();

            Assert.Throws<Exception>(() => BinaryTree.BreadthFirst(binaryTree));
        }
    }
}
