using System;
using System.Collections.Generic;
namespace IkiCore.Generic
{
    public class DynamicArray<T>
    {
        T[] items;
        public int Count { get; private set; }
        public int Capacity
        {
            get => items.Length;
            private set
            {
                if(value != items.Length)
                {
                    if(value > 0)
                    {
                        T[] newItems = new T[value];
                        if(Count > 0)
                        {
                            Array.Copy(items, 0, newItems, 0, Count);
                        }
                        items = newItems;
                    }
                    else
                    {
                        items = new T[0];
                    }
                }
            }
        }
        /// <summary>
        /// Constructs a DynamicArray. The DynamicArray is initially empty and has a capacity of zero. Upon adding the first element to the DynamicArray the capacity is increased to 16, and then increased in multiples of two as required.
        /// </summary>
        public DynamicArray()
        {
            items = new T[0];
            Count = 0;
        }
        /// <summary>
        /// Constructs a DynamicArray with a given initial capacity. The DynamicArray is initially empty, but will have room for the given number of elements before any reallocations are required.
        /// </summary>
        /// <param name="capacity"></param>
        public DynamicArray(int capacity)
        {
            items = new T[capacity];
            Count = 0;
        }
        public DynamicArray(T item)
        {
            items = new T[1];
            items[1] = item;
            Count = 1;
        }
        public DynamicArray(T[] items)
        {
            this.items = items;
            Count = items.Length;
        }
        /// <summary>
        /// Constructs a DynamicArray, copying the contents of the given collection. The size and capacity of the new list will both be equal to the size of the given collection.
        /// </summary>
        /// <param name="collection"></param>
        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection is ICollection<T> c)
            {
                int count = c.Count;
                if (count == 0)
                {
                    items = new T[0];
                }
                else
                {
                    items = new T[count];
                    c.CopyTo(items, 0);
                    Count = count;
                }
            }
            else
            {
                Count = 0;
                items = new T[0];
                using(IEnumerator<T> en = collection.GetEnumerator())
                {
                    while (en.MoveNext())
                    {
                        Add(en.Current);
                    }
                }
            }
        }
        public T this[int i]
        {
            get
            {
                if((uint)i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[i];
            }
            set
            {
                if((uint)i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[i] = value;
            }
        }
        /// <summary>
        /// Add a new element to this dynamic array.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if(Count == 2146435071)
            {
                throw new OutOfMemoryException();
            }
            else if(Count == items.Length)
            {
                CheckCapacity(Count + 1);
            }
            items[Count++] = item;
        }
        /// <summary>
        /// Removes the element at the given index. The size of the DynamicArray is decreased by one.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            int index = Array.IndexOf(items, item, 0, Count);
            if (index >= 0)
            {
                Count--;
                if (index < Count)
                {
                    Array.Copy(items, index + 1, items, index, Count - index);
                }
                items[Count] = default;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remove an element to this dynamic array at a specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if((uint)index > (uint)Count)
            {
                throw new IndexOutOfRangeException();
            }
            Count--;
            if(index < Count)
            {
                Array.Copy(items, index + 1, items, index, Count - index);
            }
            items[Count] = default;
        }
        /// <summary>
        /// Removes a range of elements from this DynamicArray.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRange(int index, int count)
        {
            if (index < 0 || count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count - index < count)
            {
                throw new ArgumentException($"Invalid Offset Length.");
            }
            if (count > 0)
            {
                Count -= count;
                if (index < Count)
                {
                    Array.Copy(items, index + count, items, index, Count - index);
                }
                Array.Clear(items, Count, count);
            }
        }
        /// <summary>
        /// This method removes all items which matches the predicate.
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public int RemoveAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            int freeIndex = 0;
            while (freeIndex < Count && !match(items[freeIndex]))
            {
                freeIndex++;
            }
            if (freeIndex >= Count)
            {
                return 0;
            }
            int current = freeIndex + 1;
            while (current < Count)
            {
                while (current < Count && match(items[current]))
                {
                    current++;
                }
                if (current < Count)
                {
                    items[freeIndex++] = items[current++];
                }
            }
            Array.Clear(items, freeIndex, Count - freeIndex);
            current = Count - freeIndex;
            Count = freeIndex;
            return current;
        }
        /// <summary>
        /// Clear the content of a dynamic array.
        /// </summary>
        public void Clear()
        {
            if(Count > 0)
            {
                Array.Clear(items, 0, Count);
                Count = 0;
            }
        }
        /// <summary>
        /// Swap two items in the DynamicArray.
        /// </summary>
        /// <param name="indexItemA"></param>
        /// <param name="indexItemB"></param>
        public void Swap(int indexItemA, int indexItemB)
        {
            if (indexItemA >= Count || indexItemA < 0 || indexItemB >= Count || indexItemB < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            T a = items[indexItemA];
            items[indexItemA] = items[indexItemB];
            items[indexItemB] = a;
        }
        public void Reverse()
        {
            T[] newArray = new T[items.Length];
            int maxLength = (Count - ((Count >> 1) << 1)) != 0 ? (Count >> 1) + 1 : Count >> 1;
            for (int i = 0; i < maxLength; i++)
            {
                newArray[i] = items[Count - i - 1];
                newArray[Count - i - 1] = items[i];
            }
            items = newArray;
        }
        /// <summary>
        /// Returns true if the specified element is in the dynamic array.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            int i = 0;
            if ((object)item == null)
            {
                for (; i < Count; i++)
                {
                    if ((object)items[i] == null)
                    {
                        return true;
                    }
                }     
                return false;
            }
            else
            {
                EqualityComparer<T> c = EqualityComparer<T>.Default;
                for (; i < Count; i++)
                {
                    if (c.Equals(items[i], item))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Return an array that countains all elements of this dynamic array.
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            T[] array = new T[Count];
            Array.Copy(items, 0, array, 0, Count);
            return array;
        }
        /// <summary>
        /// Sets the capacity of this dynamic array to the size of the dynamic array.
        /// </summary>
        public void TrimExcess()
        {
            if(Count < items.Length)
            {
                T[] newItems = new T[Count];
                Array.Copy(items, 0, newItems, 0, Count);
                items = newItems;
            }
        }
        /// <summary>
        /// Copies a section of this DynamicArray to the given array at the given index and the given count of elements.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        /// <param name="count"></param>
        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
            if (Count - index < count)
            {
                throw new ArgumentException($"Invalid Offset Length.");
            }
            Array.Copy(items, index, array, arrayIndex, count);
        }
        /// <summary>
        /// Copies a section of this DynamicArray to the given array.
        /// </summary>
        /// <param name="array"></param>
        public void CopyTo(T[] array)
        {
            if ((array != null) && (array.Rank != 1))
            {
                throw new ArgumentException($"Multi dimensionnal array not supported.");
            }
            try
            {
                Array.Copy(items, 0, array, 0, Count);
            }
            catch (ArrayTypeMismatchException)
            {
                throw new ArgumentException($"Invalid array type.");
            }
        }
        /// <summary>
        /// Copies a section of this DynamicArray to the given array at the given index.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex) => Array.Copy(items, 0, array, arrayIndex, Count);
        public DynamicArray<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        {
            if (converter == null)
            {
                throw new ArgumentNullException();
            }
            DynamicArray<TOutput> list = new DynamicArray<TOutput>(Count);
            for (int i = 0; i < Count; i++)
            {
                list.items[i] = converter(items[i]);
            }
            list.Count = Count;
            return list;
        }
        public bool Exists(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(items[i]))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Searches a section of the DynamicArray for a given element using a binary search algorithm. Elements of the DynamicArray are compared to the search value using the given IComparer interface.
        /// If comparer is null, elements of the DynamicArray are compared to the search value using the IComparable interface, which in that case must be implemented by all elements of the DynamicArray and the given search value.
        /// This method assumes that the given section of the DynamicArray is already sorted; if this is not the case, the result will be incorrect.
        /// The method returns the index of the given value in the DynamicArray. If the DynamicArray does not contain the given value, the method returns a negative integer.
        /// The bitwise complement operator (~) can be applied to a negative result to produce the index of the first element (if any) that is larger than the given search value.
        /// This is also the index at which the search value should be inserted into the DynamicArray in order for the list to remain sorted.
        /// The method uses the Array.BinarySearch method to perform the search.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <param name="item"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count - index < count)
            {
                throw new ArgumentException($"Invalid Offset Length.");
            }
            return Array.BinarySearch(items, index, count, item, comparer);
        }
        /// <summary>
        /// Searches a section of the DynamicArray for a given element using a binary search algorithm. Elements of the DynamicArray are compared to the search value using the given IComparer interface.
        /// If comparer is null, elements of the DynamicArray are compared to the search value using the IComparable interface, which in that case must be implemented by all elements of the DynamicArray and the given search value.
        /// This method assumes that the given section of the DynamicArray is already sorted; if this is not the case, the result will be incorrect.
        /// The method returns the index of the given value in the DynamicArray. If the DynamicArray does not contain the given value, the method returns a negative integer.
        /// The bitwise complement operator (~) can be applied to a negative result to produce the index of the first element (if any) that is larger than the given search value.
        /// This is also the index at which the search value should be inserted into the DynamicArray in order for the list to remain sorted.
        /// The method uses the Array.BinarySearch method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int BinarySearch(T item) => Array.BinarySearch(items, 0, Count, item, null);
        /// <summary>
        /// Searches a section of the DynamicArray for a given element using a binary search algorithm. Elements of the DynamicArray are compared to the search value using the given IComparer interface.
        /// If comparer is null, elements of the DynamicArray are compared to the search value using the IComparable interface, which in that case must be implemented by all elements of the DynamicArray and the given search value.
        /// This method assumes that the given section of the DynamicArray is already sorted; if this is not the case, the result will be incorrect.
        /// The method returns the index of the given value in the DynamicArray. If the DynamicArray does not contain the given value, the method returns a negative integer.
        /// The bitwise complement operator (~) can be applied to a negative result to produce the index of the first element (if any) that is larger than the given search value.
        /// This is also the index at which the search value should be inserted into the DynamicArray in order for the list to remain sorted.
        /// The method uses the Array.BinarySearch method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public int BinarySearch(T item, IComparer<T> comparer) => BinarySearch(0, Count, item, comparer);
        public T Find(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(items[i]))
                {
                    return items[i];
                }
            }
            return default;
        }
        public DynamicArray<T> FindAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            DynamicArray<T> list = new DynamicArray<T>();
            for (int i = 0; i < Count; i++)
            {
                if (match(items[i]))
                {
                    list.Add(items[i]);
                }
            }
            return list;
        }
        public int FindIndex(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindIndex(int startIndex, Predicate<T> match)
        {
            int count = Count - startIndex;
            if ((uint)startIndex > (uint)Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if ((uint)startIndex > (uint)Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count < 0 || startIndex > Count - count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public T FindLast(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = Count - 1; i >= 0; i--)
            {
                if (match(items[i]))
                {
                    return items[i];
                }
            }
            return default;
        }
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            if (Count == 0)
            {
                if (startIndex != -1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if ((uint)startIndex >= (uint)Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            for (int i = startIndex; i > -1; i--)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            if (Count == 0)
            {
                if (startIndex != -1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {   
                if ((uint)startIndex >= (uint)Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            if (count < 0 || startIndex - count + 1 < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int endIndex = startIndex - count;
            for (int i = startIndex; i > endIndex; i--)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Returns the index of the last occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched backwards, starting at index index and upto count elements.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.LastIndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int LastIndexOf(T item) => LastIndexOf(item, Count - 1, Count);
        /// <summary>
        /// Returns the index of the last occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched backwards, starting at index index and upto count elements.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.LastIndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int LastIndexOf(T item, int index) => LastIndexOf(item, index, index + 1);
        /// <summary>
        /// Returns the index of the last occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched backwards, starting at index index and upto count elements.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.LastIndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int LastIndexOf(T item, int index, int count)
        {
            if (Count == 0)
            {
                return -1;
            }
            if ((Count != 0 && index < 0) || (Count != 0 && count < 0))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index >= Count || count > index + 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Array.LastIndexOf(items, item, index, count);
        }
        public void ForEach(Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
        public DynamicArray<T> GetRange(int index, int count)
        {
            if (index < 0 || count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count - index < count)
            {
                throw new ArgumentException($"Invalid Offset Length.");
            }
            DynamicArray<T> list = new DynamicArray<T>(count);
            Array.Copy(items, index, list.items, 0, count);
            list.Count = count;
            return list;
        }
        /// <summary>
        /// Returns the index of the first occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched forwards from beginning to end.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.IndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item) => Array.IndexOf(items, item, 0, Count);
        /// <summary>
        /// Returns the index of the first occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched forwards from beginning to end.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.IndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int IndexOf(T item, int index)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Array.IndexOf(items, item, index, Count - index);
        }
        /// <summary>
        /// Returns the index of the first occurrence of a given value in a range of this DynamicArray. The DynamicArray is searched forwards from beginning to end.
        /// The elements of the DynamicArray are compared to the given value using the Object.Equals method.
        /// This method uses the Array.IndexOf method to perform the search.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int IndexOf(T item, int index, int count)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count < 0 || index > Count - count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Array.IndexOf(items, item, index, count);
        }
        /// <summary>
        /// Inserts an element into this DynamicArray at a given index. The size of the DynamicArray is increased by one. If required, the capacity of the DynamicArray is doubled before inserting the new element.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item)
        {
            if ((uint)index > (uint)Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count == items.Length)
            {
                CheckCapacity(Count + 1);
            }
            if (index < Count)
            {
                Array.Copy(items, index, items, index + 1, Count - index);
            }
            items[index] = item;
            Count++;
        }
        /// <summary>
        /// Inserts the elements of the given collection at a given index. If required, the capacity of the DynamicArray is increased to twice the previous capacity or the new size, whichever is larger.
        /// Ranges may be added to the end of the DynamicArray by setting index to the DynamicArray's size.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="collection"></param>
        public void InsertRange(int index, IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if ((uint)index > (uint)Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (collection is ICollection<T> c)
            {
                int count = c.Count;
                if (count > 0)
                {
                    CheckCapacity(Count + count);
                    if (index < Count)
                    {
                        Array.Copy(items, index, items, index + count, Count - index);
                    }
                    if (this == c)
                    {
                        Array.Copy(items, 0, items, index, index);
                        Array.Copy(items, index + count, items, index << 1, Count - index);
                    }
                    else
                    {
                        T[] itemsToInsert = new T[count];
                        c.CopyTo(itemsToInsert, 0);
                        itemsToInsert.CopyTo(items, index);
                    }
                    Count += count;
                }
            }
            else
            {
                using (IEnumerator<T> en = collection.GetEnumerator())
                {
                    while (en.MoveNext())
                    {
                        Insert(index++, en.Current);
                    }
                }
            }
        }
        void CheckCapacity(int min)
        {
            if (items.Length < min)
            {
                int newCapacity = items.Length == 0 ? 16 : items.Length << 2;
                if ((uint)newCapacity > 2146435071)
                {
                    newCapacity = 2146435071;
                }
                if (newCapacity < min)
                {
                    newCapacity = min;
                }
                Capacity = newCapacity;
            }
        }
    }
}
