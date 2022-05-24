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

        public static bool ValidateBrackets(string input)
        {

            char[] inputs = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == '(' || inputs[i] == '{' || inputs[i] == '[')
                {
                    stack.Push(inputs[i]);
                }
                if (inputs[i] == ')' || inputs[i] == '}' || inputs[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if (!IsMatching(stack.Pop(), inputs[i]))
                    {
                        return false;
                    }
                }
            }
            if (!(stack.Count == 0))
                return false;
            return true;
        }
        static bool IsMatching(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }
    }
}
