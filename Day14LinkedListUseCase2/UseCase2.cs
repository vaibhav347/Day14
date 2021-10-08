using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase2
{
    public class UseCase2
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(30);
            list.AddFirst(56);
            list.AddFirst(70);
            foreach (int element in list)
                Console.WriteLine(element);
        }
    }
}
