using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListUseCase7
{
    public class UseCase7
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            foreach (int element in list)
                Console.Write(element + "-->");
            Console.WriteLine();
            foreach(int element in list)
            {
                if(element == 30)
                {
                    Console.WriteLine("Fount");
                }
            }

            
        }
    }
}
