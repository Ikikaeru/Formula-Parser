using System;
using System.Collections.Generic;
namespace IkiCore
{
    public static class ExtensionDictionary
    {
        public static TValue RandomElement<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary");
            }
            var keys = dictionary.Keys;
            if (keys.Count == 0)
            {
                throw new ArgumentException("Empty dictionary");
            }
            Random rand = new Random();
            return dictionary[new List<TKey>(keys)[rand.Next(keys.Count)]];
        }
    }
}