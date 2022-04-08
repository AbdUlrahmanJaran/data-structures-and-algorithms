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
            
            LinkedList list1 = new();
            list1.Append("1");
            list1.Append("2");
            list1.Append("3");
            Console.WriteLine(list1.ToString());

            LinkedList list2 = new();
            list2.Append("4");
            list2.Append("5");
            list2.Append("6");
            Console.WriteLine(list2.ToString());

            LinkedList zippedList = LinkedList.ZipList(list1, list2);
            Console.WriteLine(zippedList.ToString());

        }
    }
}
