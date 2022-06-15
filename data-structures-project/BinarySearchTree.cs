using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(TreeNode root)
        {
            Root = root;
        }
        public void Add(int value)
        {
            TreeNode addedNode = new TreeNode(value);
            TreeNode current = Root;

            if (Root == null)
            {
                Root = addedNode;
            }

            while (current != null)
            {
                if (current.value == addedNode.value)
                {
                    break;
                }
                if (current.value > addedNode.value)
                    if (current.left != null)
                        current = current.left;
                    else
                        break;

                if (current.value < addedNode.value)
                    if (current.right != null)
                        current = current.right;
                    else
                        break;
            }
            if (current != null)
            {
                if (current.value >= addedNode.value)
                    current.left = addedNode;
                else
                    current.right = addedNode;
            }
        }

        public bool Contains(int value)
        {
            TreeNode current = Root;
            while (current != null)
            {
                if (current.value == value)
                    return true;

                if (current.value > value)
                    if (current.left != null)
                    {
                        current = current.left;
                        if (current.value == value)
                            return true;
                    }
                    else
                        break;

                if (current.value < value)
                    if (current.right != null)
                    {
                        current = current.right;
                        if (current.value == value)
                            return true;
                    }
                    else
                        break;
            }
            return false;
        }
    }
}
