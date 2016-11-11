using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtaskQueue
{
    class Program
    {
        public class myQueue<T>
        {
            private T[] Values;
            private int size;
            private const int defaultCapacity = 10;
            private int capacity;
            private int head;
            private int tail;

            public myQueue()
            {
                capacity = defaultCapacity;
                this.Values = new T[defaultCapacity];
                this.size = 0;
                this.head = -1;
                this.tail = 0;
            }

            public bool Empty()
            {
                return size == 0;
            }

            public void Enqueue(T newElement)
            {
                if (this.size == this.capacity)
                {
                    T[] newQueue = new T[2 * capacity];
                    Array.Copy(Values, 0, newQueue, 0, Values.Length);
                    Values = newQueue;
                    capacity *= 2;
                }
                size++;
                Values[tail++ % capacity] = newElement;
            }

            public T Dequeue()
            {
                size--;
                return Values[++head % capacity];
            }


            public int Count
            {
                get
                {
                    return this.size;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
