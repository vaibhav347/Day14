using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListQueueUseCase3
{
    public class UseCase3
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            Queue st = new Queue();
            st.Enqueue(list.AddFirst(70));
            st.Enqueue(list.AddFirst(30));
            st.Enqueue(list.AddFirst(56));
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
