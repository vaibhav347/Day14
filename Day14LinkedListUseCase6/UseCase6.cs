using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase6
{
    public class UseCase6
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            foreach (int element in list)
                Console.Write(element + "-->");
            list.Remove(70);
            Console.WriteLine();
            foreach (int element in list)
                Console.Write(element + "-->");
        }
    }
}
