using System.Collections.Generic;
namespace IkiCore.Generic
{
    public class Pool<T> where T : class
    {
        T[] pool;
        List<int> emptyIndexes;
        public Pool(int size)
        {
            pool = new T[size];
            emptyIndexes = new List<int>();
            for (int i = 0; i < size; i++)
            {
                emptyIndexes.Add(i);
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= pool.Length || index < 0)
                {
                    throw new System.IndexOutOfRangeException(nameof(index));
                }
                return pool[index];
            }
            set
            {

                if (index >= pool.Length || index < 0)
                {
                    throw new System.IndexOutOfRangeException(nameof(index));
                }
                pool[index] = value;
            }
        }
        public int Capacity => pool.Length - emptyIndexes.Count;
        public int Size => pool.Length;
        public int Add(T item)
        {
            if (emptyIndexes.Count > 0)
            {
                int x = emptyIndexes[0];
                pool[x] = item;
                emptyIndexes.RemoveAt(0);
                return x;
            }
            return -1;
        }
        public void Remove(int index)
        {
            if(index >= pool.Length || index < 0)
            {
                throw new System.IndexOutOfRangeException(nameof(index));
            }
            emptyIndexes.Add(index);
            pool[index] = default;
        }
        public void CleanLostIndexes()
        {
            for (int i = 0; i < pool.Length; i++)
            {
                if(pool[i] == default && !emptyIndexes.Contains(i))
                {
                    emptyIndexes.Add(i);
                }
            }
        }
        public static int operator +(Pool<T> p, T item)
        {
            int i = -1;
            if(p.emptyIndexes.Count > 0)
            {
                i = p.emptyIndexes[0];
                p.pool[i] = item;
                p.emptyIndexes.RemoveAt(0);
            }
            return i;
        }
        public static Pool<T> operator -(Pool<T> p, int index)
        {
            if (index >= p.pool.Length || index < 0)
            {
                throw new System.IndexOutOfRangeException(nameof(index));
            }
            p.emptyIndexes.Add(index);
            p.pool[index] = default;
            return p;
        }
        public static Pool<T> operator -(Pool<T> p, T item)
        {
            for (int i = 0; i < p.pool.Length; i++)
            {
                if(p.pool[i].Equals(item))
                {
                    p.emptyIndexes.Add(i);
                    p.pool[i] = default;
                    break;
                }
            }
            return p;
        }
    }
}
