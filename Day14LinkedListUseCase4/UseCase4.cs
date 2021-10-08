using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase4
{
    public class UseCase4
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            foreach (int element in list)
             Console.Write(element+"-->");
        }
    }
}
