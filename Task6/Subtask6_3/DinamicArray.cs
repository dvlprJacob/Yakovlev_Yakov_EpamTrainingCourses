using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask6_3
{
    public class DinamicArray : IEnumerable<int>,IEnumerator
    {
        public Dictionary<DateTime, Exception> Exception;
        int[] DinArray;
        int Count;
        int Position = -1;
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator(); ;
        } 

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public int Current
        {
            get 
            {
                try
                {
                    return DinArray[Position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public bool MoveNext()
        {
            Position++;
            return (Position < Count);
        }
        public void Reset()
        {
            Position = -1;
        }
        public int Length
        {
            get
            {
                return Count;
            }
        }
        public int Capacity
        {
            get
            {
                return DinArray.Length;
            }
        }
        public int this[int ind]
        {
            get
            {
                if (ind < Count && !this.Equals(null))
                    return DinArray[ind];
                else
                {
                    DateTime Now = new DateTime();
                    Now = DateTime.Now;
                    Exception.Add(Now, new IndexOutOfRangeException());
                    return Exception[Now].GetHashCode();
                }
            }
            set
            {
                if (ind < Count && !this.Equals(null))
                    DinArray[ind] = value;
                else
                {
                    Exception.Add(DateTime.Now, new IndexOutOfRangeException());
                }
            }
        }
        public DinamicArray()
        {
            Count = 8;
            DinArray = new int[12];
            Exception = new Dictionary<DateTime, System.Exception>();
        }
        public DinamicArray(int count)
        {
            if (count >= 0)
            {
                Count = count;
                DinArray = new int[count + (count / 2)];
                Exception = new Dictionary<DateTime, System.Exception>();
            }
            else
            {
                DinArray = new int[0];
                Count = 0;
                Exception = new Dictionary<DateTime, System.Exception>();
                Exception.Add(DateTime.Now, new ArgumentException("Количество должно быть больше нуля."));
            }
        }
        public DinamicArray(IEnumerable<int> Collection)
        {
            if (!Collection.Equals(null))
            {
                Count = Collection.Count();
                DinArray = new int[Count + Count / 2];
                for (int i = 0; i < Count; i++)
                    DinArray[i] = Collection.ElementAt(i);
            }
            else
            {
                DinArray = new int[0];
                Count = 0;
                Exception = new Dictionary<DateTime, System.Exception>();
                Exception.Add(DateTime.Now, new ArgumentNullException());
            }
        }
        public void Add(int item)
        {
            if (Count < Capacity)
            {
                DinArray[Count - 1] = item;
                Count++;
                return;
            }
            List<int> buf = new List<int>(DinArray);
            DinArray = new int[Capacity * 2];
            Count++;
            for (int i = 0; i < Count; i++)
                DinArray[i] = buf[i];
            buf.Clear();
            DinArray[Count - 1] = item;
            return;
        }
        public void AddRange(IEnumerable<int> Collection)
        {
            if (!Collection.Equals(null))
            {
                if (Capacity - Count < Collection.Count())
                {
                    List<int> buf = new List<int>(DinArray);
                    int CountAfter = Count;
                    DinArray = new int[(Capacity + Collection.Count()) * 2];
                    Count = Count + Collection.Count(); ;
                    for (int i = 0; i < buf.Count; i++)
                        DinArray[i] = buf[i];
                    buf.Clear();
                    int j = 0;
                    for (int i = CountAfter; i < Count; i++)
                    {
                        DinArray[i] = Collection.ElementAt(j);
                        j++;
                    }
                }
            }
            else
            {
                DinArray = new int[0];
                Count = 0;
                Exception = new Dictionary<DateTime, System.Exception>();
                Exception.Add(DateTime.Now, new ArgumentNullException());
            }
        }
        public bool Remove(int item)
        {
            int ind = -1;
            if (!this.Equals(null))
            {
                int k = 0;
                while(ind==-1 || k<Count)
                {
                    if (DinArray[k] == item)
                    {
                        ind = k;
                        k++;
                    }
                    else
                        k++;
                }
                if (ind!=-1)
                {
                    List<int> buf = new List<int>(DinArray);
                    DinArray = new int[Capacity];
                    Count = Count - 1;
                    for (int i = 0; i < ind; i++)
                        DinArray[i] = buf[i];
                    for (int i = ind; i < Count; i++)
                    {
                        DinArray[i] = buf.ElementAt(i+1);
                    }
                    buf.Clear();
                }
                return true;
            }
            if(this.Equals(null))
            {
                DinArray = new int[0];
                Count = 0;
                Exception = new Dictionary<DateTime, System.Exception>();
                Exception.Add(DateTime.Now, new InvalidOperationException("This is null"));
                return false;
            }
            if(ind==-1)
            {
                Exception.Add(DateTime.Now, new ArgumentException("Item for remove is not found."));
                return false;
            }
            return false;
        }
        public bool Insert(int item,int ind)
        {
            if(ind>Capacity)
            {
                Exception.Add(DateTime.Now, new IndexOutOfRangeException("Out of index in Reset()"));
                return false;
            }
            Count++;
            List<int> buf = new List<int>(DinArray);
            DinArray = new int[Capacity];
            for (int i = 0; i < ind; i++)
                DinArray[i] = buf[i];
            DinArray[ind] = item;
            for (int i = ind+1; i < Count; i++)
            {
                DinArray[i] = buf.ElementAt(i-1);
            }
            buf.Clear();
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)DinArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<int>)DinArray).GetEnumerator();
        }
        public override string ToString()
        {
            string str="";
            for(int i=0;i<Count;i++)
                str += string.Format("{0}->",DinArray[i]);
            str += "finish";
            return str;
        }
    }
}
