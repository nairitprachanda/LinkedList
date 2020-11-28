  
using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
    class LinkedList
    {
        //internal Node head;
        internal void Display(Node head)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
