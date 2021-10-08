using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day14StackQueueUseCase2
{
    public class UseCase2
    {
        public void insertData()
        {
            //LinkedList<int> list = new LinkedList<int>();
            Stack st = new Stack();
            st.Push(70);
            st.Push(30);
            st.Push(56);
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
            Console.WriteLine("Elements After Pop");
            st.Pop();
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
            st.Pop();
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
            st.Pop();
            foreach (int element in st)
            {
                Console.WriteLine(element);
            }

        }
    }
}
