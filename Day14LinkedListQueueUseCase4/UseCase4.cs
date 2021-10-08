using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedListQueueUseCase4
{
    public class UseCase4
    {
        public void insertData()
        {
           // LinkedList<int> list = new LinkedList<int>();
            Queue st = new Queue();
            st.Enqueue(70);
            st.Enqueue(30);
            st.Enqueue(56);
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            st.Dequeue();
            Console.WriteLine("--------------------");
            Console.WriteLine("Dequeue");
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            st.Dequeue();
            Console.WriteLine("--------------------");
            Console.WriteLine("Dequeue");
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            st.Dequeue();
            Console.WriteLine("--------------------");
            Console.WriteLine("Dequeue");
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
        }
    }
}
