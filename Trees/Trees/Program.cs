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
            Console.WriteLine(binaryTree.Contains(5));

            binaryTree.PreOrder().ForEach(Console.WriteLine);
            Console.WriteLine();
            binaryTree.InOrder().ForEach(Console.WriteLine);
            Console.WriteLine();
            binaryTree.PostOrder().ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine(binaryTree.Max());
        }
    }
}
