using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day14StackQueueUseCase1
{
    public class UseCase1
    {
        public void insertData()
        {
            LinkedList<int> list = new LinkedList<int>();
            Stack st = new Stack();
            st.Push(list.AddFirst(70));
            st.Push(list.AddFirst(30));
            st.Push(list.AddFirst(56));
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
