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
        public List<int> PreOrder()
        {
            PreOrder(Root);
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

        public List<int> InOrder()
        {
            InOrder(Root);
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

        public List<int> PostOrder()
        {
            PostOrder(Root);
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

        int max;
        public int Max()
        {
            Max(Root);
            return max;
        }

        private int Max(Node root)
        {
            if (root.value > max)
            {
                max = root.value;
            }
            if (root.left != null)
            {
                Max(root.left);
            }
            if (root.right != null)
            {
                Max(root.right);
            }
            return max;
        }

        public static List<int> BreadthFirst(BinaryTree binaryTree)
        {
            List<int> breadthFirst = new List<int>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(binaryTree.Root);

            if (binaryTree.Root == null)
                throw new Exception();

            while (queue.Count != 0)
            {

                Node front = queue.Dequeue();
                breadthFirst.Add(front.value);

                if (front.left != null)
                    queue.Enqueue(front.left);

                if (front.right != null)
                    queue.Enqueue(front.right);
            }

            return breadthFirst;
        }
    }
}
