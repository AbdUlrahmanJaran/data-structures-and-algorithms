using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    public class LinkedList
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

        public void Append(String newValue)
        {
            Node node = new Node(newValue);
            Node last = Head;
            if (Head == null)
            {
                Head = new Node(newValue);
                return;
            }
            else
            {
                while (last.NextNode != null)
                    last = last.NextNode;
                last.NextNode = node;
            }
        }

        public void InsertBefore(String value , String newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if (Head.value == value)
            {
                newNode.NextNode = Head;
                Head = newNode;
                return;
            }

            while (current.NextNode != null)
            {
                if (current.NextNode.value == value)
                {
                    newNode.NextNode = current.NextNode;
                    current.NextNode = newNode;
                    break;
                }
                current = current.NextNode;
            }

            if (current.NextNode == null)
            {
                Console.WriteLine(value+ " doesn't exist");
            }
        }

        public void InsertAfter(String value, String newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if (Head.value == value)
            {
                newNode.NextNode = Head.NextNode;
                Head.NextNode = newNode;
                return;
            }

            while (current.value != null)
            {
                if (current.value == value)
                {
                    newNode.NextNode = current.NextNode;
                    current.NextNode= newNode;
                    break;
                }
                current = current.NextNode;
                if (current == null)
                {
                    Console.WriteLine(value + " doesn't exist");
                    break;
                }
            }
        }
    }
}
