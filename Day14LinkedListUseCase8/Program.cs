using System;
using System.Collections.Generic;

namespace Day14LinkedListUseCase8
{
    class Program
    {
        static void Main()
        {
            int[] num = {56,30,70 };
            LinkedList<int> list = new LinkedList<int>(num);
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
            // adding a node at the end
            var newNode = list.AddLast(70);
            // adding a new node after the node added above
            list.AddBefore(newNode, 40);
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
