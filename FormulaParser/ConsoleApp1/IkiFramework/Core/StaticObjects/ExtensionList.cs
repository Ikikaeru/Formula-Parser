using System.Collections.Generic;
using System;
namespace IkiCore
{
    public static partial class ExtensionList
    {

        /// <summary>
        /// Return the summary of all the number in the list.
        /// </summary>
        /// <param name="intlist"></param>
        /// <returns></returns>
        public static int Sum(this IList<int> intlist)
        {
            if (intlist != null && intlist.Count > 0)
            {
                int summary = 0;
                for (int i = 0; i < intlist.Count; i++)
                {
                    summary += intlist[i];
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the list.
        /// </summary>
        /// <param name="intlist"></param>
        /// <returns></returns>
        public static long Sum(this IList<long> intlist)
        {
            if (intlist != null && intlist.Count > 0)
            {
                long summary = 0L;
                for (int i = 0; i < intlist.Count; i++)
                {
                    summary += intlist[i];
                }
                return summary;
            }
            return 0L;
        }
        /// <summary>
        /// Return the summary of all the number in the list.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <returns></returns>
        public static float Sum(this IList<float> floatlist)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                float summary = 0f;
                for (int i = 0; i < floatlist.Count; i++)
                {
                    summary += floatlist[i];
                }
                return summary;
            }
            return 0f;
        }
        /// <summary>
        /// Return the summary of all the number in the list.
        /// </summary>
        /// <param name="doublelist"></param>
        /// <returns></returns>
        public static double Sum(this IList<double> doublelist)
        {
            if (doublelist != null && doublelist.Count > 0)
            {
                double summary = 0.0;
                for (int i = 0; i < doublelist.Count; i++)
                {
                    summary += doublelist[i];
                }
                return summary;
            }
            return 0.0;
        }
        /// <summary>
        /// Return the product of all the number in the list.
        /// </summary>
        /// <param name="intlist"></param>
        /// <returns></returns>
        public static int Product(this IList<int> intlist)
        {
            if (intlist != null && intlist.Count > 0)
            {
                int product = 1;
                for (int i = 0; i < intlist.Count; i++)
                {
                    product *= intlist[i];
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the list.
        /// </summary>
        /// <param name="longlist"></param>
        /// <returns></returns>
        public static long Product(this IList<long> longlist)
        {
            if (longlist != null && longlist.Count > 0)
            {
                long product = 1L;
                for (int i = 0; i < longlist.Count; i++)
                {
                    product *= longlist[i];
                }
                return product;
            }
            return 0L;
        }
        /// <summary>
        /// Return the product of all the number in the list.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <returns></returns>
        public static float Product(this IList<float> floatlist)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                float product = 1f;
                for (int i = 0; i < floatlist.Count; i++)
                {
                    product *= floatlist[i];
                }
                return product;
            }
            return 0f;
        }
        /// <summary>
        /// Return the product of all the number in the list.
        /// </summary>
        /// <param name="doublelist"></param>
        /// <returns></returns>
        public static double Product(this IList<double> doublelist)
        {
            if (doublelist != null && doublelist.Count > 0)
            {
                double product = 1.0;
                for (int i = 0; i < doublelist.Count; i++)
                {
                    product *= doublelist[i];
                }
                return product;
            }
            return 0.0;
        }
        public static List<T> Where<T>(this IList<T> array, Func<T, bool> predicate)
        {
            List<T> w = new List<T>();
            for (int i = 0; i < array.Count; i++)
            {
                if (predicate(array[i]))
                {
                    w.Add(array[i]);
                }
            }
            return w;
        }
        /// <summary>
        /// Randomize the order of a list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            int j;
            for (int i = list.Count - 1; i > 0; i--)
            {
                Random rng = new Random((int)DateTime.Now.Ticks);
                j = rng.Next(0, i - 1);
                T e = list[i];
                list[i] = list[j];
                list[j] = e;
            }
            return list;
        }
        /// <summary>
        /// Resize the length of the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="newLength"></param>
        public static IList<T> Resize<T>(this IList<T> list, int newLength)
        {
            IList<T> newlist = (IList<T>)list.Clone();
            if (newLength < newlist.Count)
            {
                for (int i = newlist.Count - 1; i >= newLength; i--)
                {
                    newlist.RemoveAt(i);
                }
            }
            else if(newLength > newlist.Count)
            {
                for (int i = newlist.Count; i < newLength; i++)
                {
                    newlist.Add(default);
                }
            }
            return newlist;
        }
        /// <summary>
        /// Swap two items in a list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="indexA">Index of item A</param>
        /// <param name="indexB">Index of item B</param>
        /// <returns></returns>
        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            if (list.Count >= indexA || indexA < 0 || list.Count >= indexB || indexB < 0)
            {
                throw new IndexOutOfRangeException("Cannot swap item that are out of range.");
            }
            else if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Cannot swap item from a list that don't have elements.");
            }
            T a = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = a;
            return list;
        }
        /// <summary>
        /// Move an element of the list to a new index.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="oldIndex"></param>
        /// <param name="newIndex"></param>
        public static IList<T> Move<T>(this IList<T> list, int oldIndex, int newIndex)
        {
            T item = list[oldIndex];
            list.RemoveAt(oldIndex);
            list.Insert(newIndex, item);
            return list;
        }
        /// <summary>
        /// Rotate a list to the right given a pivot. The pivot is the number of element that will be placed to the right of the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static IList<T> RotateToRight<T>(this IList<T> list, int pivot)
        {
            if (pivot == 0)
            {
                return list;
            }
            else if (pivot < 0)
            {
                pivot = list.Count - (-pivot - (-pivot / list.Count) * list.Count);
            }
            pivot = pivot - (pivot / list.Count) * list.Count;
            T[] y = new T[list.Count];
            int k = 0;
            int i;
            for (i = pivot; i < list.Count; i++)
            {
                y[k] = list[i];
                k++;
            }
            for (i = 0; i < pivot; i++)
            {
                y[k] = list[i];
                k++;
            }
            return y;
        }

        /// <summary>
        /// Return all numbers in the list that are under the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<int> GetLessThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                List<int> lists = new List<int>();
                for (int i = 0; i < intlist.Count; i++)
                {
                    if (intlist[i] < a)
                    {
                        lists.Add(intlist[i]);
                    }
                }
                return lists;
            }
            return new List<int>();
        }
        /// <summary>
        /// Return all numbers in the list that are under the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<float> GetLessThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                List<float> lists = new List<float>();
                for (int i = 0; i < floatlist.Count; i++)
                {
                    if (floatlist[i] < a)
                    {
                        lists.Add(floatlist[i]);
                    }
                }
                return lists;
            }
            return new List<float>();
        }
        /// <summary>
        /// Return all numbers in the list that are over the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<int> GetMoreThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                List<int> lists = new List<int>();
                for (int i = 0; i < intlist.Count; i++)
                {
                    if (intlist[i] > a)
                    {
                        lists.Add(intlist[i]);
                    }
                }
                return lists;
            }
            return new List<int>();
        }
        /// <summary>
        /// Return all numbers in the list that are over the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<float> GetMoreThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                List<float> lists = new List<float>();
                for (int i = 0; i < floatlist.Count; i++)
                {
                    if (floatlist[i] > a)
                    {
                        lists.Add(floatlist[i]);
                    }
                }
                return lists;
            }
            return new List<float>();
        }
        /// <summary>
        /// Return all numbers in the list that are under or equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<int> GetLessEqualThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                List<int> lists = new List<int>();
                for (int i = 0; i < intlist.Count; i++)
                {
                    if (intlist[i] <= a)
                    {
                        lists.Add(intlist[i]);
                    }
                }
                return lists;
            }
            return new List<int>();
        }
        /// <summary>
        /// Return all numbers in the list that are under or equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<float> GetLessEqualThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                List<float> lists = new List<float>();
                for (int i = 0; i < floatlist.Count; i++)
                {
                    if (floatlist[i] <= a)
                    {
                        lists.Add(floatlist[i]);
                    }
                }
                return lists;
            }
            return new List<float>();
        }
        /// <summary>
        /// Return all numbers in the list that are over or equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<int> GetMoreEqualThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                List<int> lists = new List<int>();
                for (int i = 0; i < intlist.Count; i++)
                {
                    if (intlist[i] >= a)
                    {
                        lists.Add(intlist[i]);
                    }
                }
                return lists;
            }
            return new List<int>();
        }
        /// <summary>
        /// Return all numbers in the list that are over or equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<float> GetMoreEqualThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                List<float> lists = new List<float>();
                for (int i = 0; i < floatlist.Count; i++)
                {
                    if (floatlist[i] >= a)
                    {
                        lists.Add(floatlist[i]);
                    }
                }
                return lists;
            }
            return new List<float>();
        }
        /// <summary>
        /// Return all numbers in the list that are equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<int> GetEqualTo(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                List<int> lists = new List<int>();
                for (int i = 0; i < intlist.Count; i++)
                {
                    if (intlist[i] == a)
                    {
                        lists.Add(intlist[i]);
                    }
                }
                return lists;
            }
            return new List<int>();
        }
        /// <summary>
        /// Return all numbers in the list that are equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static IList<float> GetEqualTo(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                List<float> lists = new List<float>();
                for (int i = 0; i < floatlist.Count; i++)
                {
                    if (floatlist[i] == a)
                    {
                        lists.Add(floatlist[i]);
                    }
                }
                return lists;
            }
            return new List<float>();
        }
        /// <summary>
        /// Return true to all numbers in the list that are less than the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                bool[] lists = new bool[intlist.Count];
                for (int i = 0; i < intlist.Count; i++)
                {
                    lists[i] = intlist[i] < a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are less than the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                bool[] lists = new bool[floatlist.Count];
                for (int i = 0; i < floatlist.Count; i++)
                {
                    lists[i] = floatlist[i] < a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are more than the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                bool[] lists = new bool[intlist.Count];
                for (int i = 0; i < intlist.Count; i++)
                {
                    lists[i] = intlist[i] > a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are more than the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                bool[] lists = new bool[floatlist.Count];
                for (int i = 0; i < floatlist.Count; i++)
                {
                    lists[i] = floatlist[i] > a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are less or equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessEqualThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                bool[] lists = new bool[intlist.Count];
                for (int i = 0; i < intlist.Count; i++)
                {
                    lists[i] = intlist[i] <= a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are less or equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessEqualThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                bool[] lists = new bool[floatlist.Count];
                for (int i = 0; i < floatlist.Count; i++)
                {
                    lists[i] = floatlist[i] <= a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are more or equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreEqualThan(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                bool[] lists = new bool[intlist.Count];
                for (int i = 0; i < intlist.Count; i++)
                {
                    lists[i] = intlist[i] >= a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are more or equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreEqualThan(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                bool[] lists = new bool[floatlist.Count];
                for (int i = 0; i < floatlist.Count; i++)
                {
                    lists[i] = floatlist[i] >= a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are equal to the compared number.
        /// </summary>
        /// <param name="intlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsEqualTo(this IList<int> intlist, int a)
        {
            if (intlist != null && intlist.Count > 0)
            {
                bool[] lists = new bool[intlist.Count];
                for (int i = 0; i < intlist.Count; i++)
                {
                    lists[i] = intlist[i] == a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the list that are equal to the compared number.
        /// </summary>
        /// <param name="floatlist"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsEqualTo(this IList<float> floatlist, float a)
        {
            if (floatlist != null && floatlist.Count > 0)
            {
                bool[] lists = new bool[floatlist.Count];
                for (int i = 0; i < floatlist.Count; i++)
                {
                    lists[i] = floatlist[i] == a ? true : false;
                }
                return lists;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return a random item from the list.
        /// Sampling with replacement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this IList<T> list)
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Cannot select a random item from an empty list");
            }
            return list[new Random((int)DateTime.Now.Ticks).Next(0, list.Count)];
        }
        /// <summary>
        /// Return a random index of the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int GetRandomIndex<T>(this IList<T> list)
        {
            return new Random((int)DateTime.Now.Ticks).Next(0, list.Count);
        }
        /// <summary>
        /// Removes a random item from the list, returning that item.
        /// Sampling without replacement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRemoveRandom<T>(this IList<T> list)
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Cannot remove a random item from an empty list");
            }
            int index = new Random((int)DateTime.Now.Ticks).Next(0, list.Count);
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }
        /// <summary>
        /// Removes a random item from the list.
        /// Sampling without replacement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static IList<T> RemoveRandom<T>(this IList<T> list)
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Cannot remove a random item from an empty list");
            }
            list.RemoveAt(new Random((int)DateTime.Now.Ticks).Next(0, list.Count));
            return list;
        }
        /// <summary>
        /// Return a copy of a list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="listToCopy"></param>
        /// <returns></returns>
        public static IList<T> CopyList<T>(this List<T> list, IList<T> listToCopy)
        {
            list = (List<T>)list.Resize(listToCopy.Count);
            for (int i = 0; i < listToCopy.Count; ++i)
            {
                list[i] = listToCopy[i];
            }
            return list;
        }
        /// <summary>
        /// Return a cloned list of this list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<T> Clone<T>(this IList<T> list)
        {
            IList<T> newList = new List<T>();
            for (int i = 0; i < newList.Count; i = i + 1)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
        /// <summary>
        /// Reset the content of the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static IList<T> Reset<T>(this IList<T> list)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                list[i] = default(T);
            }
            return list;
        }
        /// <summary>
        /// Convert the content of this list to string values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string[] ConvertToString<T>(this IList<T> list)
        {
            string[] stringArray = new string[list.Count];
            for (int i = 0; i < list.Count; ++i)
            {
                stringArray[i] = list[i].ToString();
            }
            return stringArray;
        }
        /// <summary>
        /// Return the total length of all lists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lists"></param>
        /// <returns></returns>
        public static int GetTotalCount<T>(IList<T> list, params IList<T>[] lists)
        {
            int count = list.Count;
            for (int i = 0; i < lists.Length; ++i)
            {
                count += lists[i].Count;
            }
            return count;
        }
        /// <summary>
        /// Invert all values of the list.
        /// </summary>
        /// <param name="list"></param>
        public static IList<bool> Invert(this IList<bool> list)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                list[i] = !list[i];
            }
            return list;
        }
        public static void ForEach<T>(this IList<T> list, Action<int, T> actionToElement)
        {
            for (int i = 0; i < list.Count; i++)
            {
                actionToElement(i, list[i]);
            }
        }
        public static void ForEachAssign<T>(this IList<T> array, Func<int, T, T> actionToElement)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = actionToElement(i, array[i]);
            }
        }
        public static void ForEachAssign<T>(this IList<T> array, int width, Func<int, int, T, T> actionToElement)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = actionToElement(i % width, i / width, array[i]);
            }
        }
        public static void ForEachAssign<T>(this IList<T> array, int width, int height, Func<int, int, int, T, T> actionToElement)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = actionToElement(i % width, (i / width) % height, i / (width * height), array[i]);
            }
        }
    }
}
