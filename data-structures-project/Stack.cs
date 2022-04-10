using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class Stack
    {
        public Node top = null;

        public void Push(string value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.NextNode = top;
                top = node;
            }
        }

        public string Pop()
        {
            Node temp = top;
            if (top == null)
            {
                throw new Exception("The Stack is Empty");
            }
            
            top = top.NextNode;
            temp.NextNode = null;
            return temp.value;
        }

        public string Peek()
        {
            if (top == null)
            {
                throw new Exception("The Stack is Empty");
            }
            else
                return top.value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public String ToString()
        {
            string result = "";

            if (top == null)
            {
                return "The Stack is Empty";
            }
            else
            {
                Node current = top;
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
