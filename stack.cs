using System;
using System.Collections.Generic;

namespace Collections
{ 
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doStackDemo();
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDeno"); //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Sneha");
            stack.Push("Kiran");
            stack.Push("Gowri");
            stack.Push("Mahitha");
            stack.Push("granth");
            string pop = stack.Pop();

            // Iterating stack elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }
       
    }
}
