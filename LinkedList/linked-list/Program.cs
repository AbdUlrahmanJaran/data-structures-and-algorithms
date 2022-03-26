using System;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            Console.WriteLine(list.Includes("2"));
            Console.WriteLine(list.ToString());
        }
    }
}
