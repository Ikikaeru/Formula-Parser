using System;
using System.Collections.Generic;
namespace IkiCore
{
	public static class ExtensionEnumerable
	{
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        public static List<T> ToList<T>(this IEnumerable<T> source)
        {
            List<T> result = new List<T>();
            foreach (T item in source)
            {
                result.Add(item);
            }
            return result;
        }
        public static IEnumerable<TResult> Transformation<T, TResult>(this IEnumerable<T> list, Func<T, TResult> deleg)
        {
            List<TResult> result = new List<TResult>();
            foreach (T item in list)
            {
                result.Add(deleg(item));
            }
            return result;
        }
    }
}
