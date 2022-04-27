using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Node
    {
        public int value = 0;
        public Node left = null;
        public Node right = null;
        public Node(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
