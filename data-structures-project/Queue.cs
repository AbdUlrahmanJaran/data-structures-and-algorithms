using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class Queue
    {
        public Node front = null;
        public Node back = null;

        public void Enqueue(string value)
        {
            Node node = new Node(value);
            if (back == null)
            {
                back = node;
                front = back;
            }
            else
            back.NextNode = node;
            back = node;
        }

        public string Dequeue()
        {
            if (front == null)
            {
                throw new Exception("The Queue is Empty");
            }
            Node temp = front;
            front = front.NextNode;
            temp.NextNode = null;
            return temp.value;
        }

        public string Peek()
        {
            if (front == null)
            {
                throw new Exception("The Queue is Empty");
            }
            else
                return front.value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public String ToString()
        {
            string result = "";

            if (front == null)
            {
                return "The Queue is Empty";
            }
            else
            {
                Node current = front;
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
