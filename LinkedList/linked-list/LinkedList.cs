using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class LinkedList
    {
        Node Head;

        public void Insert(String value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.NextNode = Head;
                Head = newNode;
            }
        }

        public Boolean Includes(String value)
        {
            Node current = Head;
            while(current != null)
            {
                if (current.value == value)
                {
                    return true;
                }
                current = current.NextNode;
            }
            return false;
        }
        
        public String ToString()
        {
            string result = "";

            if (Head == null)
            {
                return "Nothing in the List";
            }
            else
            {
                Node current = Head;
                while (current != null)
                {
                    result += "[" + current.value + "] -> ";
                    current = current.NextNode;
                }
            }

            return result + "NULL";
        }
    }
}
