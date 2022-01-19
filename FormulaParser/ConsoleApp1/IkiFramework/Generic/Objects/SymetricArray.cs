using System;
using System.Collections;
using System.Collections.Generic;
using IkiCore.Mathematics;
namespace IkiCore.Generic
{
    public class SymetricArray<T> : IEnumerable<T>
    {
        int size;
        T[] array;
        public SymetricArray(int size)
        {
            this.size = size;
            array = new T[size * (size + 1) / 2];
        }
        public T this[int x, int y]
        {
            get
            {
                if (x >= size || size < 0)
                {
                    throw new IndexOutOfRangeException(nameof(x));
                }
                else if (y >= size || size < 0)
                {
                    throw new IndexOutOfRangeException(nameof(y));
                }
                int index = x.Max(y);
                index = ((index * (index + 1)) >> 0x1) + x.Min(y);
                return array[index];
            }
            set
            {
                if (x >= size || size < 0)
                {
                    throw new IndexOutOfRangeException(nameof(x));
                }
                else if (y >= size || size < 0)
                {
                    throw new IndexOutOfRangeException(nameof(y));
                }
                int index = x.Max(y);
                index = ((index * (index + 1)) >> 0x1) + x.Min(y);
                array[index] = value;
            }
        }
        /// <summary>
        /// Return true if the selected position the position is reflected.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsReflectedPosition(int x, int y)
        {
            if (x >= size || size < 0)
            {
                throw new IndexOutOfRangeException(nameof(x));
            }
            else if (y >= size || size < 0)
            {
                throw new IndexOutOfRangeException(nameof(y));
            }
            return x > y;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
        SymetricArrayEnumerator<T> GetEnumerator()
        {
            return new SymetricArrayEnumerator<T>(array);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class SymetricArrayEnumerator<T> : IEnumerator
    {
        public T[] array;
        int position = -1;
        public SymetricArrayEnumerator(T[] list)
        {
            array = list;
        }
        public bool MoveNext()
        {
            position++;
            return position < array.Length;
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public T Current
        {
            get
            {
                try
                {
                    return array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
