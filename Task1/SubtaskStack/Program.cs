using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtaskStack
{
    class Program
    {
        public class myStack<T>
        {
            private T[] Values; 
            private const int defaultCapacity = 10;
            private int size;

            public myStack()
            {
                this.size = 0;
                this.Values = new T[defaultCapacity];
            }
            public myStack(int n)
            {
                this.size = n;
                this.Values = new T[n];
            }

            public bool Empty()
            {
                return this.size == 0;
            }

            public int Count
            {
                get
                {
                    return this.size;
                }
            }

            public T Pop()
            {
                return this.Values[--this.size];
            }

            public void Push(T newElement)
            {
                if (this.size == this.Values.Length) 
                {
                    T[] newArray = new T[2 * this.Values.Length];
                    Array.Copy(this.Values, 0, newArray, 0, this.size);
                    this.Values = newArray;
                }
                this.Values[this.size++] = newElement; 
            }
            public T GetValue(int index)
            {
                try
                {
                    if (index < size)
                        return Values[index];
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                return Values[0];
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
