using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Node
    {
        public String value;
        public Node NextNode;

        public Node(String value)
        {
            this.value = value;
            this.NextNode = null;
        }
    }
}
