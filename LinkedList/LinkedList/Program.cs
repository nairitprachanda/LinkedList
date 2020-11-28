using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List!");
            LinkedList list = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;
            node3.next = null;
            Console.WriteLine("Linked List is displayed.");
            list.Display(node1);
        }
    }
}