﻿using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
        }
    }
}