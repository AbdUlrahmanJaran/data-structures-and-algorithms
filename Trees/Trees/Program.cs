using System;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(7);
            binaryTree.Add(77);
            binaryTree.Add(3);
            binaryTree.Add(8);
            binaryTree.Add(140);

            BinaryTree binaryTree2 = new BinaryTree();
            binaryTree2.Root = new Node (2);
            binaryTree2.Root.left = new Node (7);
            binaryTree2.Root.right = new Node(5);
            binaryTree2.Root.left.left = new Node (2);
            binaryTree2.Root.left.right = new Node (6);
            binaryTree2.Root.left.right.left = new Node (5);
            binaryTree2.Root.left.right.right = new Node(11);
            binaryTree2.Root.right.right = new Node(9);
            binaryTree2.Root.right.right.left = new Node (4);

            Console.WriteLine(binaryTree.Contains(5));

            binaryTree.PreOrder().ForEach(Console.WriteLine);
            Console.WriteLine();

            binaryTree.InOrder().ForEach(Console.WriteLine);
            Console.WriteLine();

            binaryTree.PostOrder().ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine(binaryTree.Max());
            Console.WriteLine();

            BinaryTree.BreadthFirst(binaryTree2).ForEach(Console.WriteLine);
            Console.WriteLine();
        }
    }
}
