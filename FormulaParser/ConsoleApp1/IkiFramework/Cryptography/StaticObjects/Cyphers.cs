using System;
using System.Collections.Generic;
namespace IkiCore.Cryptography
{
    public static class Cyphers
    {
        internal static long[] allBits = new long[]
        {
            0x1L, 0x2L, 0x4L, 0x8L, 0x10L, 0x20L, 0x40L, 0x80L,
            0x100L, 0x200L, 0x400L, 0x800L, 0x1000L, 0x2000L, 0x4000L, 0x8000L,
            0x10000L, 0x20000L, 0x40000L, 0x80000L, 0x100000L, 0x200000L, 0x400000L, 0x800000L,
            0x1000000L, 0x2000000L, 0x4000000L, 0x8000000L, 0x10000000L, 0x20000000L, 0x40000000L, 0x80000000L,
            0x10000000L, 0x20000000L, 0x40000000L, 0x80000000L, 0x100000000L, 0x200000000L, 0x400000000L, 0x800000000L,
            0x100000000L, 0x200000000L, 0x400000000L, 0x800000000L, 0x1000000000L, 0x2000000000L, 0x4000000000L, 0x8000000000L,
            0x1000000000L, 0x2000000000L, 0x4000000000L, 0x8000000000L, 0x10000000000L, 0x20000000000L, 0x40000000000L, 0x80000000000L,
            0x10000000000L, 0x20000000000L, 0x40000000000L, 0x80000000000L, 0x100000000000L, 0x200000000000L, 0x400000000000L, -9223372036854775808L
        };
        internal static int[] byteShiftIndex = new int[]
        {
            0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7
        };
        internal static int[] shortShiftIndex = new int[]
        {
            0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7,
            0x8, 0x9, 0xA, 0xB, 0xC, 0xD, 0xE, 0xF
        };
        internal static int[] intShiftIndex = new int[]
        {
            0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7,
            0x8, 0x9, 0xA, 0xB, 0xC, 0xD, 0xE, 0xF,
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
            0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F
        };
        internal static int[] longShiftIndex = new int[]
        {
            0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7,
            0x8, 0x9, 0xA, 0xB, 0xC, 0xD, 0xE, 0xF,
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
            0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F,
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27,
            0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F,
            0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
            0x38, 0x39, 0x3A, 0x3B, 0x3C, 0x3D, 0x3E, 0x3F
        };
        internal static long[] binaryMasks = new long[]
        {
            0xF0L,
            0xFL,
            0xFF00L,
            0xFFL,
            0xFFFF0000L,
            0xFFFFL,
            -4294967296L,
            0xFFFFFFFFL
        };
        internal static int[] computeCypher(int[] cypher, Random rnd)
        {
            int j, e;
            for (int i = cypher.Length - 1; i > 0; i--)
            {
                j = rnd.Next(0, i - 1);
                e = cypher[i];
                cypher[i] = cypher[j];
                cypher[j] = e;
            }
            return cypher;
        }
        internal static int[] generateCypher8(char input)
        {
            return computeCypher((int[])byteShiftIndex.Clone(), new Random(input));
        }
        internal static int[] generateCypher16(char input)
        {
            return computeCypher((int[])shortShiftIndex.Clone(), new Random(input));
        }
        internal static int[] generateCypher32(char input)
        {
            return computeCypher((int[])intShiftIndex.Clone(), new Random(input));
        }
        internal static int[] generateCypher64(char input)
        {
            return computeCypher((int[])longShiftIndex.Clone(), new Random(input));
        }
        public static byte Cypher8(byte input, char key, bool invert = false)
        {
            return (byte)Cypher(input, generateCypher8(key), invert);
        }
        public static short Cypher16(short input, char key, bool invert = false)
        {
            return (short)Cypher(input, generateCypher16(key), invert);
        }
        public static int Cypher32(int input, char key, bool invert = false)
        {
            return (int)Cypher(input, generateCypher32(key), invert);
        }
        public static long Cypher64(long input, char key, bool invert = false)
        {
            return Cypher(input, generateCypher64(key), invert);
        }
        public static long Cypher(long input, int[] cypher, bool invert = false)
        {
            long result = 0x0L;
            int actualShift, i;
            if (invert)
            {
                for (i = 0; i < cypher.Length; i++)
                {
                    actualShift = cypher[i] - longShiftIndex[i];
                    if (actualShift < 0x0)
                    {
                        result |= (allBits[longShiftIndex[i] + actualShift] & input) << -actualShift;
                    }
                    else
                    {
                        result |= (allBits[longShiftIndex[i] + actualShift] & input) >> actualShift;
                    }
                }
            }
            else
            {
                for (i = 0; i < cypher.Length; i++)
                {
                    actualShift = cypher[i] - longShiftIndex[i];
                    if (actualShift < 0x0)
                    {
                        result |= (allBits[i] & input) >> -actualShift;
                    }
                    else
                    {
                        result |= (allBits[i] & input) << actualShift;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Bit index = 0 byte, 1 short, 2 int, 3 long
        /// </summary>
        /// <param name="input"></param>
        /// <param name="bitIndex"></param>
        public static void BitsPermute(List<long> input, int bitIndex = 3)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Count - 1;
            int nextIndex;
            long leftNext, right;
            for (int i = 0; i < input.Count; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & binaryMasks[bitIndex]) >> shift;
                input[i] = (input[i] & binaryMasks[bitIndex]) | leftNext;
                input[nextIndex] = (input[nextIndex] & binaryMasks[bitIndex + 1]) | right;
            }
        }
        public static void BitsPermute(long[] input, int bitIndex = 3)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Length - 1;
            int nextIndex;
            long leftNext, right;
            for (int i = 0; i < input.Length; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & binaryMasks[bitIndex]) >> shift;
                input[i] = (input[i] & binaryMasks[bitIndex]) | leftNext;
                input[nextIndex] = (input[nextIndex] & binaryMasks[bitIndex + 1]) | right;
            }
        }
        public static void BitsPermute(List<int> input, int bitIndex = 2)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Count - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Count; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (input[i] & (int)binaryMasks[bitIndex]) | leftNext;
                input[nextIndex] = (input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right;
            }
        }
        public static void BitsPermute(int[] input, int bitIndex = 2)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Length - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Length; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (input[i] & (int)binaryMasks[bitIndex]) | leftNext;
                input[nextIndex] = (input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right;
            }
        }
        public static void BitsPermute(List<short> input, int bitIndex = 1)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Count - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Count; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (short)((input[i] & (int)binaryMasks[bitIndex]) | leftNext);
                input[nextIndex] = (short)((input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right);
            }
        }
        public static void BitsPermute(short[] input, int bitIndex = 1)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Length - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Length; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (short)((input[i] & (int)binaryMasks[bitIndex]) | leftNext);
                input[nextIndex] = (short)((input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right);
            }
        }
        public static void BitsPermute(List<byte> input, int bitIndex = 0)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Count - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Count; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (byte)((input[i] & (int)binaryMasks[bitIndex]) | leftNext);
                input[nextIndex] = (byte)((input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right);
            }
        }
        public static void BitsPermute(byte[] input, int bitIndex = 0)
        {
            int shift = 0x4 << bitIndex;
            bitIndex *= 2;
            int cMinO = input.Length - 1;
            int nextIndex, leftNext, right;
            for (int i = 0; i < input.Length; i++)
            {
                nextIndex = i == cMinO ? 0 : i + 1;
                right = (input[i] & (int)binaryMasks[bitIndex + 1]) << shift;
                leftNext = (input[nextIndex] & (int)binaryMasks[bitIndex]) >> shift;
                input[i] = (byte)((input[i] & (int)binaryMasks[bitIndex]) | leftNext);
                input[nextIndex] = (byte)((input[nextIndex] & (int)binaryMasks[bitIndex + 1]) | right);
            }
        }
        public static byte[] To8Bits(short input)
        {
            byte[] b = new byte[2];
            b[0] = (byte)input;
            b[1] = (byte)(input >> 8);
            return b;
        }
        public static byte[] To8Bits(int input)
        {
            byte[] b = new byte[4];
            b[0] = (byte)input;
            b[1] = (byte)(input >> 8);
            b[2] = (byte)(input >> 16);
            b[3] = (byte)(input >> 24);
            return b;
        }
        public static byte[] To8Bits(long input)
        {
            byte[] b = new byte[8];
            b[0] = (byte)input;
            b[1] = (byte)(input >> 8);
            b[2] = (byte)(input >> 16);
            b[3] = (byte)(input >> 24);
            b[4] = (byte)(input >> 32);
            b[5] = (byte)(input >> 40);
            b[6] = (byte)(input >> 48);
            b[7] = (byte)(input >> 56);
            return b;
        }
        public static short[] To16Bits(int input)
        {
            short[] s = new short[2];
            s[0] = (short)input;
            s[1] = (short)(input >> 16);
            return s;
        }
        public static short[] To16Bits(long input)
        {
            short[] s = new short[2];
            s[0] = (short)input;
            s[1] = (short)(input >> 16);
            s[2] = (short)(input >> 32);
            s[3] = (short)(input >> 48);
            return s;
        }
        public static int[] To32Bits(long input)
        {
            int[] i = new int[2];
            i[0] = (int)input;
            i[0] = (int)(input >> 32);
            return i;
        }
        public static char[] LongToChar(long input)
        {
            char[] c = new char[4];
            c[0] = (char)input;
            c[1] = (char)(input >> 16);
            c[2] = (char)(input >> 32);
            c[3] = (char)(input >> 48);
            return c;
        }
        public static long[] CharToLong(char[] input)
        {
            if (input.Length % 4 != 0)
            {
                throw new Exception("Corrupt array...");
            }
            long[] l = new long[input.Length / 4];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = input[i * 4] | ((long)input[i * 4 + 1] << 16) | ((long)input[i * 4 + 2] << 32) | ((long)input[i * 4 + 3] << 48);
            }
            return l;
        }
    }
}
