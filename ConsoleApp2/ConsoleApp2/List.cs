using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class List<T>
    {
        private T[] data;
        public int Count { get; private set; }
        public List()
        {
            data = new T[0];
        }

        public void Add(T x)
        {
            Array.Resize(ref data, Count + 1);
            data[Count] = x;
            ++Count;
        }

        public void Insert(int index,T value)
        {
            if (Count==0 || index>=Count-1)
            {
                Add(value);
            }
            else
            {
                Array.Resize(ref data, Count + 1);
                ++Count;
                for (int i = Count - 1; i > index; i--)
                {
                    data[i] = data[i - 1];
                }
                data[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index<Count)
            {
                for (int i = index; i < Count-1; i++)
                {
                    data[i] = data[i + 1];
                }
                Array.Resize(ref data, Count - 1);
                Count--;
            }
        }

       public void Clear()
        {
            Count = 0;
        }

        public T this[int key]
        {
            get
            {
                return data[key];
            }

            set
            {
                data[key] = value;
            }

        }

        public bool Constains(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(data[i]))
                    return true;
            }
            return false;
        }

        public int IndexOf(T item)
        {
            Comparer<T> a = Comparer<T>.Default;
            for (int i = 0; i < Count; i++)
            {   
                if (a.Compare(data[i], item) == 0)
                {
                    return i; 
                }
            }
            return -1;
        }

        public void ForEach(System.Action<T> action)
        {
            for (int i = 0; i != Count; ++i)
            {
                action(data[i]);
            }
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(data[i]))
                    return data[i];
            }
            return default (T);
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(data[i]))
                    return i;
            }
            return -1;
        }
    }
}
