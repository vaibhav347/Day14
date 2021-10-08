using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase5
{
    public class UseCase5
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            foreach (int element in list)
                Console.Write(element + "-->");
            list.Remove(56);
            Console.WriteLine();
            foreach (int element in list)
                Console.Write(element + "-->");
        }
    }
}
