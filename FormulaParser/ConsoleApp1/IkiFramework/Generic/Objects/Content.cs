using System.Collections.Generic;
namespace IkiCore.Generic
{
	public class Content<T>
	{
        List<T> elements = new List<T>();
        public int Count => elements.Count;
        public T this[int index]
        {
            get
            {
                if(index >= elements.Count || index < 0)
                {
                    throw new System.IndexOutOfRangeException(nameof(index));
                }
                return elements[index];
            }
            set
            {
                if (index >= elements.Count || index < 0)
                {
                    throw new System.IndexOutOfRangeException(nameof(index));
                }
                elements[index] = value;
            }
        }
        public static Content<T> operator ~(Content<T> a)
        {
            a.elements.Reverse();
            return a;
        }
        public static Content<T> operator +(Content<T> a, T b)
        {
            a.elements.Add(b);
            return a;
        }
        public static Content<T> operator ++(Content<T> a)
        {
            a.elements.Add(default);
            return a;
        }
        public static Content<T> operator -(Content<T> a, T b)
        {
            a.elements.Remove(b);
            return a;
        }
        public static Content<T> operator /(Content<T> a, T b)
        {
            for (int i = a.elements.Count - 1; i >= 0; i--)
            {
                if(a.elements[i].Equals(b))
                {
                    a.elements.RemoveAt(i);
                }
            }
            return a;
        }
        public static Content<T> operator --(Content<T> a)
        {
            a.elements.Remove(default);
            return a;
        }
        public static Content<T> operator &(Content<T> a, T b)
        {
            if (a.elements.Contains(b))
            {
                a.elements.Add(b);
            }
            return a;
        }
        public static Content<T> operator |(Content<T> a, T b)
        {
            if (!a.elements.Contains(b))
            {
                a.elements.Add(b);
            }
            return a;
        }
    }
}
