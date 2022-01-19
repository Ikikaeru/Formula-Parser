using System.Collections.Generic;
using System;
using IkiCore.Mathematics;
using IkiCore.Generic;
namespace IkiCore
{
    public static partial class ExtensionArray
    {
        public static void ForEach<T>(this T[] array, Action<int, T> actionToElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                actionToElement(i, array[i]);
            }
        }
        public static void ForEach<T>(this T[,] array, Action<int, int, T> actionToElement)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    actionToElement(j, i, array[j, i]);
                }
            }
        }
        public static void ForEach<T>(this T[,,] array, Action<int, int, int, T> actionToElement)
        {
            for (int i = 0; i < array.GetLength(2); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(0); k++)
                    {
                        actionToElement(k, j, i, array[k, j, i]);
                    }
                }
            }
        }
        public static void ForEachAssign<T>(this T[] array, Func<int, T, T> actionToElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = actionToElement(i, array[i]);
            }
        }
        public static void ForEachAssign<T>(this T[,] array, Func<int, int, T, T> actionToElement)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    array[j, i] = actionToElement(j, i, array[j, i]);
                }
            }
        }
        public static void ForEachAssign<T>(this T[,,] array, Func<int, int, int, T, T> actionToElement)
        {
            for (int i = 0; i < array.GetLength(2); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(0); k++)
                    {
                        array[k, j, i] = actionToElement(k, j, i, array[k, j, i]);
                    }
                }
            }
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static sbyte Sum(this sbyte[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                sbyte summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = (sbyte)(summary + intarray[i]);
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static byte Sum(this byte[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                byte summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = (byte)(summary + intarray[i]);
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static short Sum(this short[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                short summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = (short)(summary + intarray[i]);
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static ushort Sum(this ushort[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                ushort summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = (ushort)(summary + intarray[i]);
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static int Sum(this int[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                int summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = summary + intarray[i];
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static uint Sum(this uint[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                uint summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = summary + intarray[i];
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static long Sum(this long[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                long summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = summary + intarray[i];
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static ulong Sum(this ulong[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                ulong summary = 0;
                for (int i = 0; i < intarray.Length; i++)
                {
                    summary = summary + intarray[i];
                }
                return summary;
            }
            return 0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static float Sum(this float[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                float summary = 0f;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    summary += floatarray[i];
                }
                return summary;
            }
            return 0f;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static double Sum(this double[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double summary = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    summary = summary + floatarray[i];
                }
                return summary;
            }
            return 0.0;
        }
        /// <summary>
        /// Return the summary of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static decimal Sum(this decimal[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                decimal summary = 0.0m;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    summary = summary + floatarray[i];
                }
                return summary;
            }
            return 0.0m;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static sbyte Product(this sbyte[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                sbyte product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = (sbyte)(product * intarray[i]);
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static byte Product(this byte[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                byte product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = (byte)(product * intarray[i]);
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static short Product(this short[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                short product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = (short)(product * intarray[i]);
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static ushort Product(this ushort[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                ushort product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = (ushort)(product * intarray[i]);
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static int Product(this int[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                int product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = product * intarray[i];
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static uint Product(this uint[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                uint product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = product * intarray[i];
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static long Product(this long[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                long product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = product * intarray[i];
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="intarray"></param>
        /// <returns></returns>
        public static ulong Product(this ulong[] intarray)
        {
            if (intarray != null && intarray.Length > 0)
            {
                ulong product = intarray[0];
                for (int i = 1; i < intarray.Length; i++)
                {
                    product = product * intarray[i];
                }
                return product;
            }
            return 0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static float Product(this float[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                float product = floatarray[0];
                for (int i = 1; i < floatarray.Length; i++)
                {
                    product = product * floatarray[i];
                }
                return product;
            }
            return 0f;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static double Product(this double[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double product = floatarray[0];
                for (int i = 1; i < floatarray.Length; i++)
                {
                    product = product * floatarray[i];
                }
                return product;
            }
            return 0.0;
        }
        /// <summary>
        /// Return the product of all the number in the array.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <returns></returns>
        public static decimal Product(this decimal[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                decimal product = floatarray[0];
                for (int i = 1; i < floatarray.Length; i++)
                {
                    product = product * floatarray[i];
                }
                return product;
            }
            return 0.0m;
        }
        /// <summary>
        /// Return all numbers in the array that are under the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static int[] GetLessThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                List<int> arrays = new List<int>();
                for (int i = 0; i < intarray.Length; i++)
                {
                    if (intarray[i] < a)
                    {
                        arrays.Add(intarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new int[0];
        }
        /// <summary>
        /// Return all numbers in the array that are under the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static float[] GetLessThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                List<float> arrays = new List<float>();
                for (int i = 0; i < floatarray.Length; i++)
                {
                    if (floatarray[i] < a)
                    {
                        arrays.Add(floatarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new float[0];
        }
        /// <summary>
        /// Return all numbers in the array that are over the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static int[] GetMoreThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                List<int> arrays = new List<int>();
                for (int i = 0; i < intarray.Length; i++)
                {
                    if (intarray[i] > a)
                    {
                        arrays.Add(intarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new int[0];
        }
        /// <summary>
        /// Return all numbers in the array that are over the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static float[] GetMoreThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                List<float> arrays = new List<float>();
                for (int i = 0; i < floatarray.Length; i++)
                {
                    if (floatarray[i] > a)
                    {
                        arrays.Add(floatarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new float[0];
        }
        /// <summary>
        /// Return all numbers in the array that are under or equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static int[] GetLessEqualThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                List<int> arrays = new List<int>();
                for (int i = 0; i < intarray.Length; i++)
                {
                    if (intarray[i] <= a)
                    {
                        arrays.Add(intarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new int[0];
        }
        /// <summary>
        /// Return all numbers in the array that are under or equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static float[] GetLessEqualThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                List<float> arrays = new List<float>();
                for (int i = 0; i < floatarray.Length; i++)
                {
                    if (floatarray[i] <= a)
                    {
                        arrays.Add(floatarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new float[0];
        }
        /// <summary>
        /// Return all numbers in the array that are over or equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static int[] GetMoreEqualThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                List<int> arrays = new List<int>();
                for (int i = 0; i < intarray.Length; i++)
                {
                    if (intarray[i] >= a)
                    {
                        arrays.Add(intarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new int[0];
        }
        /// <summary>
        /// Return all numbers in the array that are over or equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static float[] GetMoreEqualThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                List<float> arrays = new List<float>();
                for (int i = 0; i < floatarray.Length; i++)
                {
                    if (floatarray[i] >= a)
                    {
                        arrays.Add(floatarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new float[0];
        }
        /// <summary>
        /// Return all numbers in the array that are equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static int[] GetEqualTo(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                List<int> arrays = new List<int>();
                for (int i = 0; i < intarray.Length; i++)
                {
                    if (intarray[i] == a)
                    {
                        arrays.Add(intarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new int[0];
        }
        /// <summary>
        /// Return all numbers in the array that are equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static float[] GetEqualTo(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                List<float> arrays = new List<float>();
                for (int i = 0; i < floatarray.Length; i++)
                {
                    if (floatarray[i] == a)
                    {
                        arrays.Add(floatarray[i]);
                    }
                }
                return arrays.ToArray();
            }
            return new float[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are less than the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                bool[] arrays = new bool[intarray.Length];
                for (int i = 0; i < intarray.Length; i++)
                {
                    arrays[i] = intarray[i] < a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are less than the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                bool[] arrays = new bool[floatarray.Length];
                for (int i = 0; i < floatarray.Length; i++)
                {
                    arrays[i] = floatarray[i] < a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are more than the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                bool[] arrays = new bool[intarray.Length];
                for (int i = 0; i < intarray.Length; i++)
                {
                    arrays[i] = intarray[i] > a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are more than the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                bool[] arrays = new bool[floatarray.Length];
                for (int i = 0; i < floatarray.Length; i++)
                {
                    arrays[i] = floatarray[i] > a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are less or equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessEqualThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                bool[] arrays = new bool[intarray.Length];
                for (int i = 0; i < intarray.Length; i++)
                {
                    arrays[i] = intarray[i] <= a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are less or equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsLessEqualThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                bool[] arrays = new bool[floatarray.Length];
                for (int i = 0; i < floatarray.Length; i++)
                {
                    arrays[i] = floatarray[i] <= a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are more or equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreEqualThan(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                bool[] arrays = new bool[intarray.Length];
                for (int i = 0; i < intarray.Length; i++)
                {
                    arrays[i] = intarray[i] >= a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are more or equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsMoreEqualThan(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                bool[] arrays = new bool[floatarray.Length];
                for (int i = 0; i < floatarray.Length; i++)
                {
                    arrays[i] = floatarray[i] >= a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are equal to the compared number.
        /// </summary>
        /// <param name="intarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsEqualTo(this int[] intarray, int a)
        {
            if (intarray != null && intarray.Length > 0)
            {
                bool[] arrays = new bool[intarray.Length];
                for (int i = 0; i < intarray.Length; i++)
                {
                    arrays[i] = intarray[i] == a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return true to all numbers in the array that are equal to the compared number.
        /// </summary>
        /// <param name="floatarray"></param>
        /// <param name="a">Compared number</param>
        /// <returns></returns>
        public static bool[] IsEqualTo(this float[] floatarray, float a)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                bool[] arrays = new bool[floatarray.Length];
                for (int i = 0; i < floatarray.Length; i++)
                {
                    arrays[i] = floatarray[i] == a ? true : false;
                }
                return arrays;
            }
            return new bool[0];
        }
        /// <summary>
        /// Return a random element of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this T[] array)
        {
            if (array.Length == 0)
            {
                throw new IndexOutOfRangeException("Cannot select a random item from an empty array");
            }
            return array[new Random((int)DateTime.Now.Ticks).Next(0, array.Length)];
        }
        /// <summary>
        /// Return a random index of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetRandomIndex<T>(this T[] array)
        {
            return new Random((int)DateTime.Now.Ticks).Next(0, array.Length);
        }
        /// <summary>
        /// Removes a random item from the array, returning that item.
        /// Sampling without replacement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] RemoveRandom<T>(this T[] array)
        {
            if (array.Length == 0)
            {
                throw new IndexOutOfRangeException("Cannot remove a random item from an empty array");
            }
            T item = array[new Random((int)DateTime.Now.Ticks).Next(0, array.Length)];
            T[] newArray = new T[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (!array[i].Equals(item))
                {
                    newArray[j] = array[i];
                    j = j + 1;
                }
            }
            return newArray;
        }
        /// <summary>
        /// Return true if the array contain the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Contains<T>(this T[] array, T value)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Return a copy of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="arrayToCopy"></param>
        /// <returns></returns>
        public static T[] CopyArray<T>(this T[] array, T[] arrayToCopy)
        {
            array = array.Resize(arrayToCopy.Length);
            for (int i = 0; i < arrayToCopy.Length; ++i)
            {
                array[i] = arrayToCopy[i];
            }
            return array;
        }
        /// <summary>
        /// Return a cloned array of this array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] Clone<T>(this T[] array)
        {
            T[] newArray = new T[array.Length];
            for (int i = 0; i < newArray.Length; i = i + 1)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        /// <summary>
        /// Reset the content of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Reset<T>(this T[] array)
        {
            array = new T[array.Length];
        }
        /// <summary>
        /// Convert the content of this array to string values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string[] ConvertToString<T>(this T[] array)
        {
            string[] stringArray = new string[array.Length];
            for (int i = 0; i < array.Length; i = i + 1)
            {
                stringArray[i] = array[i].ToString();
            }
            return stringArray;
        }
        /// <summary>
        /// Return the total length of all arrays.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public static int GetTotalCount<T>(T[] array, params T[][] arrays)
        {
            int count = array.Length;
            for (int i = 0; i < arrays.Length; ++i)
            {
                count += arrays[i].Length;
            }
            return count;
        }
        /// <summary>
        /// Invert all values of the array.
        /// </summary>
        /// <param name="array"></param>
        public static bool[] Invert(this bool[] array)
        {
            for (int i = 0; i < array.Length; i = i + 1)
            {
                array[i] = !array[i];
            }
            return array;
        }
        /// <summary>
        /// Return true if the position is in the range of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsInRange<T>(this T[,] obj, int x, int y)
        {
            return x > -1 && x < obj.GetLength(0) && y > -1 && y < obj.GetLength(1);
        }

        public static bool IsInRange<T>(this T[,,] obj, int x, int y, int z)
        {
            return x > -1 && x < obj.GetLength(0) && y > -1 && y < obj.GetLength(1) && z > -1 && z < obj.GetLength(2);
        }
        /// <summary>
        /// Return true if the position is in the edge of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsInEdge<T>(this T[,] obj, int x, int y)
        {
            return x == 0 || x == obj.GetLength(0) - 1 || y == 0 || y == obj.GetLength(1) - 1;
        }
        /// <summary>
        /// Return true if the position is in the edge of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsInEdge<T>(this T[,,] obj, int x, int y, int z)
        {
            return x == 0 || x == obj.GetLength(0) - 1 || y == 0 || y == obj.GetLength(1) - 1 || z == 0 || z == obj.GetLength(2) - 1;
        }
        /// <summary>
        /// Return true if the position is the corner of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsInCorner<T>(this T[,] obj, int x, int y)
        {
            return (x == 0 && y == 0) || (x == obj.GetLength(0) - 1 && y == 0) || (x == 0 && y == obj.GetLength(1) - 1) || (x == obj.GetLength(0) - 1 && y == obj.GetLength(1) - 1);
        }
        /// <summary>
        /// Return true if the object is a neighbour of the actual object on a specific position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="neighbour"></param>
        /// <returns></returns>
        public static bool IsNeighbour<T>(this T[,] obj, int x, int y, T neighbour)
        {
            int i, j;
            for (i = x - 1; i < x + 2; i++)
            {
                for (j = y - 1; j < y + 2; j++)
                {
                    if (obj.IsInRange(i, j))
                    {
                        if (obj[i, j].Equals(neighbour))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Return the neighbours of the actual position in the array with the specified direction. Exemple: position[x = 3, y = 0] direction[1, 0] => Neighbour[4, 0].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="directionX"></param>
        /// <param name="directionY"></param>
        /// <returns></returns>
        public static T GetNeighbour<T>(this T[,] obj, int x, int y, int directionX = 0, int directionY = 0)
        {
            if (obj.IsInRange(x + directionX, y + directionY) && (directionX != 0 && directionY != 0))
            {
                return obj[x + directionX, y + directionY];
            }
            return default(T);
        }
        /// <summary>
        /// Return all the neighbours of the actual position in the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static T[] GetAllNeighbours<T>(this T[,] obj, int x, int y)
        {
            List<T> lst = new List<T>();
            int i, j;
            for (i = x - 1; i < x + 2; i++)
            {
                for (j = y - 1; j < y + 2; j++)
                {
                    if (obj.IsInRange(i, j) && (i != x && j != y))
                    {
                        lst.Add(obj[j, i]);
                    }
                }
            }
            return lst.ToArray();
        }
        /// <summary>
        /// Return the element of the specified position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static T GetElementIn2DArray<T>(this T[,] obj, int x, int y)
        {
            if (obj.IsInRange(x, y))
            {
                return obj[x, y];
            }
            return default(T);
        }
        /// <summary>
        /// Resize a 2D array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static T[,] Resize<T>(this T[,] array, int2 size)
        {
            T[,] newArray = new T[size.x, size.y];
            int2 pos;
            pos.x = 0;
            pos.y = 0;
            int i, j;
            for (i = 0; i < size.x; ++i)
            {
                for (j = 0; j < size.y; j++)
                {
                    pos.x = i < array.GetLength(0) ? i : -1;
                    pos.y = j < array.GetLength(1) ? j : -1;
                    if (array.IsInRange(pos.x, pos.y))
                    {
                        newArray[pos.x, pos.y] = array[pos.x, pos.y];
                    }
                    else
                    {
                        newArray[pos.x, pos.y] = default(T);
                    }
                }
            }
            return newArray;
        }
        /// <summary>
        /// Return an array that got both array values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static T[] JoinArray<T>(this T[] array, T[] array2)
        {
            T[] newArray = new T[array.Length + array2.Length];
            int i;
            for (i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (i = array.Length; i < newArray.Length; i++)
            {
                newArray[i] = array2[i];
            }
            return newArray;
        }
        /// <summary>
        /// Return an array that got all the arrays from the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public static T[] JoinMultipleArray<T>(this T[] array, params T[][] arrays)
        {
            int counts = array.Length;
            int i, j, arrayIndex;
            for (i = 0; i < arrays.Length; i++)
            {
                counts += arrays[i].Length;
            }
            T[] newArray = new T[counts];
            counts = 0;
            for (i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
                counts++;
            }
            for (i = 0; i < arrays.Length; i++)
            {
                arrayIndex = 0;
                for (j = counts; j < counts + arrays[i].Length; j++)
                {
                    newArray[j] = arrays[i][arrayIndex];
                    arrayIndex++;
                }
            }
            return newArray;
        }
        public static List<int2> FloodFill<T>(this T[,] array, int startX, int startY)
        {
            List<int2> tiles;
            tiles = new List<int2>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            T tileType = array[startX, startY];
            Queue<int2> queue;
            queue = new Queue<int2>();
            int2 startVec;
            startVec.x = startX;
            startVec.y = startY;
            queue.Enqueue(startVec);
            mapFlag[startX, startY] = true;
            int2 tempWH, tile;
            int x, y;
            while (queue.Count > 0)
            {
                tile = queue.Dequeue();
                tiles.Add(tile);
                tempWH.x = tile.x + 2;
                tempWH.y = tile.y + 2;
                for (y = tile.y - 1; y < tempWH.y; y++)
                {
                    for (x = tile.x - 1; x < tempWH.x; x++)
                    {
                        if ((x > -1 && x < mapFlag.GetLength(0) && y > -1 && y < mapFlag.GetLength(1)) && (y == tile.y || x == tile.x) && mapFlag[x, y] == false && array[x, y].Equals(tileType))
                        {
                            mapFlag[x, y] = true;
                            startVec.x = x;
                            startVec.y = y;
                            queue.Enqueue(startVec);
                        }
                    }
                }
            }
            return tiles;
        }
        public static List<List<int2>> RegionFloodFill<T>(this T[,] array, T value)
        {
            List<List<int2>> regions;
            regions = new List<List<int2>>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            List<int2> newRegion;
            int x, y, i;
            for (y = 0; y < array.GetLength(1); y++)
            {
                for (x = 0; x < array.GetLength(0); x++)
                {
                    if (mapFlag[x, y] == false && array[x, y].Equals(value))
                    {
                        newRegion = array.FloodFill(x, y);
                        regions.Add(newRegion);
                        for (i = 0; i < newRegion.Count; i++)
                        {
                            mapFlag[newRegion[i].x, newRegion[i].y] = true;
                        }
                    }
                }
            }
            return regions;
        }
        public static List<T> Where<T>(this T[] array, Func<T, bool> predicate)
        {
            List<T> w = new List<T>();
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    w.Add(array[i]);
                }
            }
            return w;
        }
        public static List<int> MaxActivitySelection<T>(this T[] startTime, T[] finishTime, int maxActivitySet) where T : System.IComparable<T>
        {
            List<int> activity = new List<int>();
            if (maxActivitySet >= startTime.Length || maxActivitySet >= finishTime.Length)
            {
                throw new Exception("There can't be more activity than those perform during startTime and finishTime.");
            }
            if (startTime.Length != finishTime.Length)
            {
                throw new Exception("There can't be more or less startTime than finishTime.");
            }
            int i, j;
            i = 0;
            activity.Add(i);
            for (j = 1; j < maxActivitySet; j++)
            {
                if (startTime[j].GreaterThanOrEqual(finishTime[i]))
                {
                    i = j;
                    activity.Add(j);
                }
            }
            return activity;
        }
        public static void Sort0N(this sbyte[] array)
        {
            int i, length = array.Length;
            sbyte temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this byte[] array)
        {
            int i, length = array.Length;
            byte temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this int[] array)
        {
            int i, length = array.Length;
            int temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this uint[] array)
        {
            int i, length = array.Length;
            uint temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this long[] array)
        {
            int i, length = array.Length;
            long temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this ulong[] array)
        {
            int i, length = array.Length;
            ulong temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this half[] array)
        {
            int i, length = array.Length;
            half temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this float[] array)
        {
            int i, length = array.Length;
            float temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this double[] array)
        {
            int i, length = array.Length;
            double temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        public static void Sort0N(this decimal[] array)
        {
            int i, length = array.Length;
            decimal temp;
            for (i = length / 2 - 1; i >= 0; i--)
            {
                heapify(array, length, i);
            }
            for (i = length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }
        static void heapify(sbyte[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                sbyte swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(byte[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                byte swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(int[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(uint[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                uint swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(long[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                long swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(ulong[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                ulong swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(half[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                half swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(float[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                float swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(double[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                double swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        static void heapify(decimal[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                decimal swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, length, largest);
            }
        }
        /// <summary>
        /// Randomize the order of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] Shuffle<T>(this T[] array)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int j;
            for (int i = array.Length - 1; i > 0; i--)
            {
                j = r.Next(0, i - 1);
                T e = array[i];
                array[i] = array[j];
                array[j] = e;
            }
            return array;
        }
        /// <summary>
        /// Randomize the order of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] ShuffleMore<T>(this T[] array)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int j;
            for (int i = array.Length - 1; i > 0; i--)
            {
                j = r.Next(0, array.Length);
                T e = array[i];
                array[i] = array[j];
                array[j] = e;
            }
            return array;
        }
        /// <summary>
        /// Resize a 1D array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="newLength"></param>
        /// <returns></returns>
        public static T[] Resize<T>(this T[] array, int newLength)
        {
            T[] newArray = new T[newLength];
            for (int i = 0; i < newLength; ++i)
            {
                newArray[i] = i < array.Length ? array[i] : default(T);
            }
            return newArray;
        }
        /// <summary>
        /// Swap two items in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="indexA">Index of item A</param>
        /// <param name="indexB">Index of item B</param>
        /// <returns></returns>
        public static T[] Swap<T>(this T[] array, int indexA, int indexB)
        {
            if (array.Length >= indexA || indexA < 0 || array.Length >= indexB || indexB < 0)
            {
                throw new IndexOutOfRangeException("Cannot swap item that are out of range.");
            }
            else if (array.Length == 0)
            {
                throw new IndexOutOfRangeException("Cannot swap item from an array that don't have elements.");
            }
            T a = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = a;
            return array;
        }
        /// <summary>
        /// Move an element of the array to a new index.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="oldIndex"></param>
        /// <param name="newIndex"></param>
        public static T[] Move<T>(this T[] array, int oldIndex, int newIndex)
        {
            if (oldIndex != newIndex)
            {
                T item = array[oldIndex];
                if (oldIndex > newIndex)
                {
                    for (int i = oldIndex; i > newIndex; i = i - 1)
                    {
                        array[i] = array[i - 1];
                    }
                }
                else
                {
                    for (int i = oldIndex; i < newIndex; i = i + 1)
                    {
                        array[i] = array[i + 1];
                    }
                }
                array[newIndex] = item;
            }
            return array;
        }
        /// <summary>
        /// Rotate an array to the right given a pivot. The pivot is the number of element that will be placed to the right of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static T[] RotateToRight<T>(this T[] array, int pivot)
        {
            if (pivot == 0)
            {
                return array;
            }
            else if (pivot < 0)
            {
                pivot = array.Length - (-pivot - (-pivot / array.Length) * array.Length);
            }
            pivot = pivot - (pivot / array.Length) * array.Length;
            T[] y = new T[array.Length];
            int k = 0;
            for (int i = pivot; i < array.Length; i++)
            {
                y[k] = array[i];
                k++;
            }
            for (int j = 0; j < pivot; j++)
            {
                y[k] = array[j];
                k++;
            }
            return y;
        }
        /// <summary>
        /// Add an element to the end of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T[] Add<T>(this T[] array, T value)
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; ++i)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = value;
            return newArray;
        }
        /// <summary>
        /// Remove an element from the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T[] Remove<T>(this T[] array, T value)
        {
            T[] newArray = new T[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (!array[i].Equals(value))
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }
        /// <summary>
        /// Remove an element from the array by index.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static T[] RemoveAt<T>(this T[] array, int index)
        {
            T[] newArray = new T[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (i != index)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }
        /// <summary>
        /// Insert an element at an index of the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T[] Insert<T>(this T[] array, int index, T value)
        {
            T[] newArray = new T[array.Length + 1];
            int j = 0;
            for (int i = 0; i < array.Length + 1; ++i)
            {
                if (i != index)
                {
                    newArray[i] = array[j];
                    j++;
                }
                else
                {
                    newArray[i] = value;
                }
            }
            return newArray;
        }
        /// <summary>
        /// Reverse the order of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] Reverse<T>(this T[] array)
        {
            T[] newArray;
            int maxLength;
            newArray = new T[array.Length];
            maxLength = (array.Length - (array.Length / 2) * 2) != 0 ? array.Length / 2 + 1 : array.Length / 2;
            for (int i = 0; i < maxLength; i++)
            {
                newArray[i] = array[newArray.Length - (i + 1)];
                newArray[newArray.Length - (i + 1)] = array[i];
            }
            return newArray;
        }
        /// <summary>
        /// Reverse the order of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void ReverseItself<T>(this T[] array)
        {
            T tempValue;
            int maxLength;
            maxLength = array.Length / 2;
            for (int i = 0; i < maxLength; i++)
            {
                tempValue = array[array.Length - (i + 1)];
                array[array.Length - (i + 1)] = array[i];
                array[i] = tempValue;
            }
        }
        /// <summary>
        /// Return true if the position is in 2D Range.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsInRange2D<T>(this T[] array, int x, int y, int width)
        {
            return x < width && x >= 0 && y < array.Length / width && y >= 0 && (x + y * width) < array.Length;
        }
        /// <summary>
        /// Return true if the position is in the edge of a 2D grid.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static bool IsInEdge2D<T>(this T[] array, int x, int y, int width)
        {
            return x == width - 1 || x == 0 || y == array.Length / width || y == 0;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static sbyte[] SortN0(this sbyte[] array)
        {
            sbyte[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = (sbyte)(store[max] + store[j]);
                    store[j] = (sbyte)(store[max] - store[j]);
                    store[max] = (sbyte)(store[max] - store[j]);
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static short[] SortN0(this short[] array)
        {
            short[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = (short)(store[max] + store[j]);
                    store[j] = (short)(store[max] - store[j]);
                    store[max] = (short)(store[max] - store[j]);
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static ushort[] SortN0(this ushort[] array)
        {
            ushort[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = (ushort)(store[max] + store[j]);
                    store[j] = (ushort)(store[max] - store[j]);
                    store[max] = (ushort)(store[max] - store[j]);
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortN0(this int[] array)
        {
            int[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static uint[] SortN0(this uint[] array)
        {
            uint[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static long[] SortN0(this long[] array)
        {
            long[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static ulong[] SortN0(this ulong[] array)
        {
            ulong[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static float[] SortN0(this float[] array)
        {
            float[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double[] SortN0(this double[] array)
        {
            double[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
        /// <summary>
        /// Return the array sorted from max to min.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static decimal[] SortN0(this decimal[] array)
        {
            decimal[] store = Clone(array);
            int i, j, n, max;
            n = store.Length - 1;
            for (j = 0; j < n; j++)
            {
                max = j;
                for (i = j + 1; i < store.Length; i++)
                {
                    if (store[i] > store[max])
                    {
                        max = i;
                    }
                }
                if (max != j)
                {
                    store[max] = store[max] + store[j];
                    store[j] = store[max] - store[j];
                    store[max] = store[max] - store[j];
                }
            }
            return store;
        }
    }
}
