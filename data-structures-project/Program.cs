using System;
using System.Collections.Generic;

namespace data_structures_project
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Data Structure Project");
            //Stack stack = new Stack();
            //stack.Push("1");
            //stack.Push("2");
            //Console.WriteLine(stack.ToString());
            //stack.Pop();
            //Console.WriteLine(stack.ToString());

            //Queue queue = new Queue();
            //queue.Enqueue("1");
            //queue.Enqueue("2");
            //queue.Enqueue("3");
            //Console.WriteLine(queue.ToString());
            //queue.Dequeue();
            //Console.WriteLine(queue.ToString());

            //PseudoQueue pseudoQueue = new PseudoQueue();
            //pseudoQueue.Enqueue("1");
            //pseudoQueue.Enqueue("2");
            //pseudoQueue.Enqueue("3");
            //pseudoQueue.Enqueue("4");
            //pseudoQueue.Dequeue();

            //AnimalShelter animalShelter = new AnimalShelter();
            //Animal cat = new Cat();
            //animalShelter.Enqueue(new Dog());
            //animalShelter.Enqueue(new Dog());
            //animalShelter.Enqueue(cat);
            //animalShelter.Enqueue(cat);
            //animalShelter.Enqueue(cat);
            //Console.WriteLine(animalShelter.Dequeue("cat"));
            //Console.WriteLine(animalShelter.Dequeue("cat"));
            //Console.WriteLine(animalShelter.Dequeue("dog"));
            //Console.WriteLine(animalShelter.Dequeue("at"));

            Console.Write(ValidateBrackets("{ } ()kk){ }"));

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
                    else if(!isMatching(stack.Pop(),inputs[i]))
                    {
                        return false;
                    }
                }
            }
            if (!(stack.Count == 0))
                return false;
            return true;
        }
        static bool isMatching(char char1, char char2)
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
