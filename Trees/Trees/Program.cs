using System;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(5);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(8);
            binaryTree.Add(14);
            Console.WriteLine(binaryTree.Contains(5));

            binaryTree.PreOrder(binaryTree).ForEach(Console.WriteLine);
            Console.WriteLine();
            binaryTree.InOrder(binaryTree).ForEach(Console.WriteLine);
            Console.WriteLine();
            binaryTree.PostOrder(binaryTree).ForEach(Console.WriteLine);
        }
    }
}
