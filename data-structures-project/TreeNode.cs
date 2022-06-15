using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class TreeNode
    {
        public int value = 0;
        public TreeNode left = null;
        public TreeNode right = null;
        public TreeNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
