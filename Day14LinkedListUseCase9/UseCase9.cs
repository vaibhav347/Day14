using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase9
{
    public class UseCase9
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(70);
            list.AddFirst(40);
            list.AddFirst(30);
            list.AddFirst(56);
            foreach (int data in list)
                Console.Write(data + "-->");
            list.Remove(40);
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("List After Delete Node 40");
            foreach (int data in list)
                Console.Write(data + "-->");
            Console.WriteLine();
            Console.WriteLine("---------------");
            int a = list.Count;
            Console.WriteLine("Size : " + a);



        }
    }
}
