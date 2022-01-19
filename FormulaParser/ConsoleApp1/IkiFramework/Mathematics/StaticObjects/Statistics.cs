using IkiCore.Core;
using System.Collections.Generic;
namespace IkiCore.Mathematics
{
    public static class Statistics
    {
        #region Median(IList<Numbers> sortedArray)-(Numbers[] array)
        public static double Median(IList<sbyte> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<byte> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<short> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<ushort> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<int> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<uint> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<long> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<ulong> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<half> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<float> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static double Median(IList<double> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5;
        }
        public static decimal Median(IList<decimal> sortedArray)
        {
            if ((sortedArray.Count & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Count + 1) >> 1];
            }
            return (sortedArray[sortedArray.Count >> 1] + sortedArray[(sortedArray.Count + 2) >> 1]) * 0.5m;
        }
        public static double Median(sbyte[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(byte[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(short[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(ushort[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(int[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(uint[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(long[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(ulong[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(half[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(float[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static double Median(double[] sortedArray)
        {
            if((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5;
        }
        public static decimal Median(decimal[] sortedArray)
        {
            if ((sortedArray.Length & 0x1) == 0x1)
            {
                return sortedArray[(sortedArray.Length + 1) >> 1];
            }
            return (sortedArray[sortedArray.Length >> 1] + sortedArray[(sortedArray.Length + 2) >> 1]) * 0.5m;
        }
        #endregion
        #region ArithmeticMean(IList<Numbers> list)-(Numbers[] array)
        public static double ArithmeticMean(IList<sbyte> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<byte> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<short> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<ushort> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<int> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<uint> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<long> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<ulong> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<half> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<float> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static double ArithmeticMean(IList<double> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0;
        }
        public static decimal ArithmeticMean(IList<decimal> floatarray)
        {
            if (floatarray != null && floatarray.Count > 0)
            {
                decimal average = 0.0m;
                for (int i = 0; i < floatarray.Count; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Count;
            }
            return 0.0m;
        }
        public static double ArithmeticMean(sbyte[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(byte[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(short[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(ushort[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(int[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(uint[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(long[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(ulong[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(half[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return (float)(average / floatarray.Length);
            }
            return 0.0;
        }
        public static double ArithmeticMean(float[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static double ArithmeticMean(double[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                double average = 0.0;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0;
        }
        public static decimal ArithmeticMean(decimal[] floatarray)
        {
            if (floatarray != null && floatarray.Length > 0)
            {
                decimal average = 0.0m;
                for (int i = 0; i < floatarray.Length; i++)
                {
                    average += floatarray[i];
                }
                return average / floatarray.Length;
            }
            return 0.0m;
        }
        #endregion
        #region HarmonicMean(IList<Numbers> list)-(Numbers[] array)
        public static double HarmonicMean(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0;
        }
        public static decimal HarmonicMean(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal sumHarmonic = 0.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0.0m)
                    {
                        return decimal.MaxValue;
                    }
                    sumHarmonic += 1.0m / array[i];
                }
                return array.Count / sumHarmonic;
            }
            return 0.0m;
        }
        public static double HarmonicMean(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static double HarmonicMean(double[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sumHarmonic = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i] == 0.0)
                    {
                        return double.PositiveInfinity;
                    }
                    sumHarmonic += 1.0 / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0;
        }
        public static decimal HarmonicMean(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal sumHarmonic = 0.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0.0m)
                    {
                        return decimal.MaxValue;
                    }
                    sumHarmonic += 1.0m / array[i];
                }
                return array.Length / sumHarmonic;
            }
            return 0.0m;
        }
        #endregion
        #region GeometricMean(IList<Numbers> list)-(Numbers[] array)
        public static double GeometricMean(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static double GeometricMean(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Count);
            }
            return 0.0;
        }
        public static decimal GeometricMean(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal geomProduct = 1.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    geomProduct *= array[i];
                }
                return (decimal)System.Math.Pow((double)geomProduct, 1.0 / array.Count);
            }
            return 0.0m;
        }
        public static double GeometricMean(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static double GeometricMean(double[] array)
        {
            if (array != null && array.Length > 0)
            {
                double geomProduct = 1.0;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return System.Math.Pow(geomProduct, 1.0 / array.Length);
            }
            return 0.0;
        }
        public static decimal GeometricMean(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal geomProduct = 1.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    geomProduct *= array[i];
                }
                return (decimal)System.Math.Pow((double)geomProduct, 1.0 / array.Length);
            }
            return 0.0m;
        }
        #endregion
        #region RootMeanSquare(IList<Numbers> list)-(Numbers[] array)
        public static double RootMeanSquare(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static double RootMeanSquare(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Count);
            }
            return 0.0;
        }
        public static decimal RootMeanSquare(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal sum = 0.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i] * array[i];
                }
                return (decimal)System.Math.Sqrt((double)sum / array.Count);
            }
            return 0.0m;
        }
        public static double RootMeanSquare(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static double RootMeanSquare(double[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return System.Math.Sqrt(sum / array.Length);
            }
            return 0.0;
        }
        public static decimal RootMeanSquare(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal sum = 0.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array[i];
                }
                return (decimal)System.Math.Sqrt((double)sum / array.Length);
            }
            return 0.0m;
        }
        #endregion
        #region MovingMean(IList<Numbers> list)-(Numbers[] array)
        public static double MovingMean(IList<sbyte> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<byte> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<short> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<ushort> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<int> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<uint> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<long> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<ulong> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<half> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<float> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static double MovingMean(IList<double> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0;
        }
        public static decimal MovingMean(IList<decimal> array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Count);
                }
                else if (values == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0m;
                }
                else if (values > 1)
                {
                    return ((array.Count - 1) * MovingMean(array, array.Count - 1) + array[values - 1]) / array.Count;
                }
            }
            return 0.0m;
        }
        public static double MovingMean(sbyte[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(byte[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(short[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(ushort[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(int[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(uint[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(long[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(ulong[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(half[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(float[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static double MovingMean(double[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0;
        }
        public static decimal MovingMean(decimal[] array, int values = -2)
        {
            if (array != null)
            {
                if (values == -2)
                {
                    return MovingMean(array, array.Length);
                }
                else if (values == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0m;
                }
                else if (values > 1)
                {
                    return ((array.Length - 1) * MovingMean(array, array.Length - 1) + array[values - 1]) / array.Length;
                }
            }
            return 0.0m;
        }
        #endregion
        #region ExponentialMovingMean(IList<Numbers> list)-(Numbers[] array, double alpha)
        public static double ExponentialMovingMean(IList<sbyte> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<byte> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<short> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<ushort> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<int> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<uint> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<long> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<ulong> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<half> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<float> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(IList<double> array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0;
        }
        public static decimal ExponentialMovingMean(IList<decimal> array, decimal alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Count);
                }
                else if (value == 1)
                {
                    return array.Count > 0 ? array[0] : 0.0m;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0m - alpha) * ExponentialMovingMean(array, array.Count - 1);
                }
            }
            return 0.0m;
        }
        public static double ExponentialMovingMean(sbyte[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(byte[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(short[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(ushort[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(int[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(uint[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(long[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(ulong[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(half[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(float[] array, double alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static double ExponentialMovingMean(double[] array, double alpha, int value = -2)
        {
            if(array != null)
            {
                if(value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if(value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0 - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0;
        }
        public static decimal ExponentialMovingMean(decimal[] array, decimal alpha, int value = -2)
        {
            if (array != null)
            {
                if (value == -2)
                {
                    return ExponentialMovingMean(array, array.Length);
                }
                else if (value == 1)
                {
                    return array.Length > 0 ? array[0] : 0.0m;
                }
                else if (value > 1)
                {
                    return alpha * array[value - 1] + (1.0m - alpha) * ExponentialMovingMean(array, array.Length - 1);
                }
            }
            return 0.0m;
        }
        #endregion
        #region GeneralizedMean(IList<Numbers> list)-(Numbers[] array, double p)
        public static double GeneralizedMean(IList<sbyte> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<byte> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<short> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<ushort> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<int> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<uint> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<long> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<ulong> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<half> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<float> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(IList<double> array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Count > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Count; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Count; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Count > 0)
                    {
                        return System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static decimal GeneralizedMean(IList<decimal> array, double p)
        {
            if (array != null)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += System.Math.Pow((double)array[i], p);
                }
                if (array.Count > 0)
                {
                    return (decimal)System.Math.Pow(1.0 / array.Count * sum, 1.0 / p);
                }
            }
            return 0.0m;
        }
        public static double GeneralizedMean(sbyte[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(byte[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(short[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(ushort[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(int[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(uint[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(long[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(ulong[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(half[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(float[] array, double p)
        {
            if (array != null)
            {
                if (p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if (p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static double GeneralizedMean(double[] array, double p)
        {
            if(array != null)
            {
                if(p == double.PositiveInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum < array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else if(p == double.NegativeInfinity && array.Length > 0)
                {
                    double sum = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        sum = sum > array[i] ? array[i] : sum;
                    }
                    return sum;
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += System.Math.Pow(array[i], p);
                    }
                    if (array.Length > 0)
                    {
                        return System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                    }
                }
            }
            return 0.0;
        }
        public static decimal GeneralizedMean(decimal[] array, double p)
        {
            if (array != null)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += System.Math.Pow((double)array[i], p);
                }
                if (array.Length > 0)
                {
                    return (decimal)System.Math.Pow(1.0 / array.Length * sum, 1.0 / p);
                }
            }
            return 0.0m;
        }
        #endregion
        #region WeightedArithmeticMean(IList<Numbers> array, IList<double> weight)-(Numbers[] array, double[] weight)
        public static double WeightedArithmeticMean(IList<sbyte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<byte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<short> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<ushort> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<int> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<uint> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<long> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<ulong> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<half> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<float> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(IList<double> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static decimal WeightedArithmeticMean(IList<decimal> array, IList<decimal> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                decimal num = 0.0m, denum = 0.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0m;
        }
        public static double WeightedArithmeticMean(sbyte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(byte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(short[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(ushort[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(int[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(uint[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(long[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(ulong[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(half[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(float[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedArithmeticMean(double[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static decimal WeightedArithmeticMean(decimal[] array, decimal[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                decimal num = 0.0m, denum = 0.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    num += array[i] * weight[i];
                    denum += weight[i];
                }
                return num / denum;
            }
            return 0.0m;
        }
        #endregion
        #region WeightedHarmonicMean(IList<Numbers> array, IList<double> weight)-(Numbers[] array, Numbers[] weight)
        public static double WeightedHarmonicMean(IList<sbyte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<byte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<short> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<ushort> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<int> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<uint> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<long> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<ulong> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<half> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<float> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(IList<double> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static decimal WeightedHarmonicMean(IList<decimal> array, IList<decimal> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                decimal num = 0.0m, denum = 0.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0m;
        }
        public static double WeightedHarmonicMean(sbyte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(byte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(short[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(ushort[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(int[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(uint[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(long[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(ulong[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(half[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(float[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static double WeightedHarmonicMean(double[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0;
        }
        public static decimal WeightedHarmonicMean(decimal[] array, decimal[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                decimal num = 0.0m, denum = 0.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i];
                    denum += weight[i] / array[i];
                }
                return num / denum;
            }
            return 0.0m;
        }
        #endregion
        #region WeightedGeometricMean(IList<Numbers> array, IList<double> weight)-(Numbers[] array, Numbers[] weight)
        public static double WeightedGeometricMean(IList<sbyte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<byte> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<short> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<ushort> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<int> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<uint> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<long> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<ulong> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<half> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<float> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<double> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(IList<decimal> array, IList<double> weight)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    denum += weight[i];
                    num += weight[i] * (double)(array[i] * array[i]);
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(sbyte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(byte[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(short[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(ushort[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(int[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(uint[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(long[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(ulong[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(half[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(float[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(double[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * array[i] * array[i];
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        public static double WeightedGeometricMean(decimal[] array, double[] weight)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double num = 0.0, denum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    denum += weight[i];
                    num += weight[i] * (double)(array[i] * array[i]);
                }
                return System.Math.Sqrt(num / denum);
            }
            return 0.0;
        }
        #endregion
        #region WeightedRootMeanSquare(IList<Numbers> array, IList<double> weight)-(Numbers[] array, double[] weight)
        public static double WeightedRootMeanSquare(IList<sbyte> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<byte> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<short> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<ushort> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<int> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<uint> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<long> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<ulong> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<half> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<float> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<double> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(IList<decimal> array, IList<double> weight)
        {
            if (array != null && array.Count > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    num += weight[i] * (double)(array[i] * array[i]);
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(sbyte[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(byte[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(short[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(ushort[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(int[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(uint[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(long[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(ulong[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(half[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(float[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(double[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * array[i] * array[i];
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        public static double WeightedRootMeanSquare(decimal[] array, double[] weight)
        {
            if (array != null && array.Length > 0)
            {
                double num = 0.0, denom = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    num += weight[i] * (double)(array[i] * array[i]);
                    denom += weight[i];
                }
                return System.Math.Sqrt(num / denom);
            }
            return 0.0;
        }
        #endregion
        #region WeightedGeneralizedMean(IList<Numbers> array, IList<double> weight, double p)-(Numbers[] array, Numbers[] weight, double p)
        public static double WeightedGeneralizedMean(IList<sbyte> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<byte> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<short> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<ushort> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<int> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<uint> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<long> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<ulong> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<half> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<float> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<double> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(IList<decimal> array, IList<double> weight, double p)
        {
            if (array != null && weight != null && array.Count == weight.Count)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += weight[i] * System.Math.Pow((double)array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(sbyte[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(byte[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(short[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(ushort[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(int[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(uint[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(long[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(ulong[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(half[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(float[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(double[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow(array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        public static double WeightedGeneralizedMean(decimal[] array, double[] weight, double p)
        {
            if (array != null && weight != null && array.Length == weight.Length)
            {
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += weight[i] * System.Math.Pow((double)array[i], p);
                }
                return System.Math.Pow(sum, 1.0 / p);
            }
            return 0.0;
        }
        #endregion
        #region WeightedMovingMean(IList<Numbers> array)-(Numbers[] array)
        public static double WeightedMovingMean(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += (ulong)i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double sum = 0.0;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0;
        }
        public static decimal WeightedMovingMean(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal sum = 0.0m;
                for (int i = array.Count; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0m * (sum / (array.Count * (array.Count + 1)));
            }
            return 0.0m;
        }
        public static double WeightedMovingMean(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += (ulong)i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static double WeightedMovingMean(double[] array)
        {
            if (array != null && array.Length > 0)
            {
                double sum = 0.0;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0 * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0;
        }
        public static decimal WeightedMovingMean(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal sum = 0.0m;
                for (int i = array.Length; i > 0; i--)
                {
                    sum += i * array[i - 1];
                }
                return 2.0m * (sum / (array.Length * (array.Length + 1)));
            }
            return 0.0m;
        }
        #endregion
        #region AverageAbsoluteDeviation(IList<Numbers> array)-(Numbers[] array)
        public static double AverageAbsoluteDeviation(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static decimal AverageAbsoluteDeviation(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal arithMean = ArithmeticMean(array);
                decimal sum = 0.0m;
                for (int i = 0; i < array.Count; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Count;
            }
            return 0.0m;
        }
        public static double AverageAbsoluteDeviation(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double AverageAbsoluteDeviation(double[] array)
        {
            if(array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static decimal AverageAbsoluteDeviation(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal arithMean = ArithmeticMean(array);
                decimal sum = 0.0m;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += Math.Abs(array[i] - arithMean);
                }
                return sum / array.Length;
            }
            return 0.0m;
        }
        #endregion
        #region AvgAbsDevAroundMedian(IList<Numbers> sortedList)-(Numbers[] sortedArray)
        public static double AvgAbsDevAroundMedian(IList<sbyte> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<byte> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<short> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<ushort> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<int> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<uint> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<long> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<ulong> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<half> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<float> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(IList<double> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0;
        }
        public static decimal AvgAbsDevAroundMedian(IList<decimal> sortedArray)
        {
            if (sortedArray != null && sortedArray.Count > 0)
            {
                decimal median = Median(sortedArray);
                decimal sum = 0.0m;
                for (int i = 0; i < sortedArray.Count; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Count;
            }
            return 0.0m;
        }
        public static double AvgAbsDevAroundMedian(sbyte[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(byte[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(short[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(ushort[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(int[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(uint[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(long[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(ulong[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(half[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(float[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static double AvgAbsDevAroundMedian(double[] sortedArray)
        {
            if(sortedArray != null && sortedArray.Length >0)
            {
                double median = Median(sortedArray);
                double sum = 0.0;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0;
        }
        public static decimal AvgAbsDevAroundMedian(decimal[] sortedArray)
        {
            if (sortedArray != null && sortedArray.Length > 0)
            {
                decimal median = Median(sortedArray);
                decimal sum = 0.0m;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sum += Math.Abs(sortedArray[i] - median);
                }
                return sum / sortedArray.Length;
            }
            return 0.0m;
        }
        #endregion
        #region Variance(IList<Numbers> list)-(Numbers[] array)
        public static double Variance(IList<sbyte> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<byte> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<short> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<ushort> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<int> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<uint> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<long> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<ulong> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<half> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<float> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static double Variance(IList<double> array)
        {
            if (array != null && array.Count > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0;
        }
        public static decimal Variance(IList<decimal> array)
        {
            if (array != null && array.Count > 0)
            {
                decimal arithMean = ArithmeticMean(array);
                decimal sum = 0.0m;
                decimal sqr;
                for (int i = 0; i < array.Count; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Count;
            }
            return 0.0m;
        }
        public static double Variance(sbyte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(short[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(ushort[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(uint[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(long[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(ulong[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(half[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(float[] array)
        {
            if (array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static double Variance(double[] array)
        {
            if(array != null && array.Length > 0)
            {
                double arithMean = ArithmeticMean(array);
                double sum = 0.0;
                double sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0;
        }
        public static decimal Variance(decimal[] array)
        {
            if (array != null && array.Length > 0)
            {
                decimal arithMean = ArithmeticMean(array);
                decimal sum = 0.0m;
                decimal sqr;
                for (int i = 0; i < array.Length; i++)
                {
                    sqr = array[i] - arithMean;
                    sum += sqr * sqr;
                }
                return sum / array.Length;
            }
            return 0.0m;
        }
        #endregion
        #region StandardDeviation(IList<double> list)-(double[] array)
        public static double StandardDeviation(IList<sbyte> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<byte> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<short> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<ushort> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<int> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<uint> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<long> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<ulong> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<half> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<float> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<double> array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(IList<decimal> array) => System.Math.Sqrt((double)Variance(array));
        public static double StandardDeviation(sbyte[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(byte[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(short[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(ushort[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(int[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(uint[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(long[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(ulong[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(half[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(float[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(double[] array) => System.Math.Sqrt(Variance(array));
        public static double StandardDeviation(decimal[] array) => System.Math.Sqrt((double)Variance(array));
        #endregion
    }
}
