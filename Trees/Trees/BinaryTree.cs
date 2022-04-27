using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root;

        List<int> preOrder = new List<int>();
        List<int> inOrder = new List<int>();
        List<int> postOrder = new List<int>();

        public BinaryTree()
        {

        }
        public BinaryTree(Node node)
        {
            Root = node;
        }
        public List<int> PreOrder(BinarySearchTree binarySearchTree)
        {
            PreOrder(binarySearchTree.Root);
            return preOrder;
        }
        
        private List<int> PreOrder(Node root)
        {
            try
            {
                preOrder.Add(root.value);
            }
            catch (Exception)
            {
                throw;
            }
            if (root.left != null)
            {
                PreOrder(root.left);
            }
            if (root.right != null)
            {
                PreOrder(root.right);
            }
            return preOrder;
        }

        public List<int> InOrder(BinarySearchTree binarySearchTree)
        {
            InOrder(binarySearchTree.Root);
            return inOrder;
        }
        private List<int> InOrder(Node root)
        {
            if (root.left != null)
            {
                InOrder(root.left);
            }
            try
            {
                inOrder.Add(root.value);
            }
            catch (Exception)
            {
                throw;
            }
            if (root.right != null)
            {
                InOrder(root.right);
            }
            return inOrder;
        }

        public List<int> PostOrder(BinarySearchTree binarySearchTree)
        {
            PostOrder(binarySearchTree.Root);
            return postOrder;
        }
        private List<int> PostOrder(Node root)
        {
            if (root.left != null)
            {
                PostOrder(root.left);
            }
            if (root.right != null)
            {
                PostOrder(root.right);
            }
            try
            {
                postOrder.Add(root.value);
            }
            catch (Exception)
            {
                throw;
            }
            return postOrder;
        }
    }
}
