using System;
using System.Collections.Generic;
namespace IkiCore.Generic
{
	public class DualList<T0, T1>
	{
        List<T0> elementA = new List<T0>();
        List<T1> elementB = new List<T1>();
        public Tuple<T0, T1> this[int index]
        {
            get
            {
                if(index >= elementA.Count || index < 0)
                {
                    throw new IndexOutOfRangeException(nameof(index));
                }
                return new Tuple<T0, T1>(elementA[index], elementB[index]);
            }
            set
            {
                if (index >= elementA.Count || index < 0)
                {
                    throw new IndexOutOfRangeException(nameof(index));
                }
                elementA[index] = value.Item1;
                elementB[index] = value.Item2;
            }
        }
        public T0 Item1(int index)
        {
            if (index >= elementA.Count || index < 0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return elementA[index];
        }
        public T1 Item2(int index)
        {
            if (index >= elementA.Count || index < 0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return elementB[index];
        }
        public List<T0> ItemList1() => elementA;
        public List<T1> ItemList2() => elementB;
        public void Add(T0 item1, T1 item2)
        {
            elementA.Add(item1);
            elementB.Add(item2);
        }
        public void Insert(int index, T0 item1, T1 item2)
        {
            if (index >= elementA.Count || index < 0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            elementA.Insert(index, item1);
            elementB.Insert(index, item2);
        }
        public void RemoveAt(int index)
        {
            if (index >= elementA.Count || index < 0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            elementA.RemoveAt(index);
            elementB.RemoveAt(index);
        }
    }
}
