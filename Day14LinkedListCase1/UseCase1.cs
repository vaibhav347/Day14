using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListCase1
{
    public class UseCase1
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(56);
            list.AddFirst(30);
            list.AddFirst(70);
            foreach (int element in list)
                Console.WriteLine(element);
        }
    }
}
