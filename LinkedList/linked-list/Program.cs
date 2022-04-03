using System;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Insertion");
            LinkedList list = new();
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            Console.WriteLine("This is my list");
            Console.WriteLine(list.ToString());
            Console.WriteLine("I want to Append '4'");
            list.Append("4");
            Console.WriteLine(list.ToString());
            Console.WriteLine("I want to Insert '5' After '4'");
            list.InsertAfter("4", "5");
            Console.WriteLine(list.ToString());
            Console.WriteLine("I want to Insert '0' before '1'");
            list.InsertBefore("1", "0");
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.KthFromEnd(4));
            
        }
    }
}
