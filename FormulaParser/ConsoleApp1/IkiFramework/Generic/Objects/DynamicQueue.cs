using System.Collections.Generic;
namespace IkiCore.Generic
{
	public class DynamicQueue<T>
	{
        List<T> values = new List<T>();
        public T this[int i] { get => values[i]; set => values[i] = value; }
        public int Count => values.Count;
        public T Peek() => values.Count > 0 ? values[0] : default;
        public void Enqueue(T item) => values.Add(item);
        public void Enqueue(IEnumerable<T> items) => values.AddRange(items);
        public T Dequeue()
        {
            if(values.Count > 0)
            {
                T v = values[0];
                values.RemoveAt(0);
                return v;
            }
            return default;
        }
        public List<T> Dequeues(int count)
        {
            T[] dequeued = new T[count];
            values.CopyTo(0, dequeued, 0, count);
            values.RemoveRange(0, count);
            return new List<T>(dequeued);
        }
        public void Remove(T item) => values.Remove(item);
        public void RemoveAt(int index) => values.RemoveAt(index);
        public void Clear() => values.Clear();
    }
}
