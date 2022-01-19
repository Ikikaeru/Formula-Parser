using System.Runtime.InteropServices;
namespace IkiCore.Binary
{
    public static class BinaryMod
	{
        [StructLayout(LayoutKind.Explicit)]
        internal struct IntToFloat
        {
            [FieldOffset(0)]
            public int intValue;
            [FieldOffset(0)]
            public float floatValue;
        }
        [StructLayout(LayoutKind.Explicit)]
        internal struct LongToDouble
        {
            [FieldOffset(0)]
            public long longValue;
            [FieldOffset(0)]
            public double doubleValue;
        }
        public static int Equal(int x, int y) => -(~(x - y | y - x) >> 31);
        public static int LessThan(int x, int y) => -(((x & ~y) | (~(x ^ y) & (x - y))) >> 31);
        public static int GreaterThan(int x, int y) => -(((y & ~x) | (~(y ^ x) & (y - x))) >> 31);
        public static int LEqual(int x, int y) => -(((~(x ^ y) >> 1) + (x & ~y)) >> 31);
        public static int GEqual(int x, int y) => -(((~(y ^ x) >> 1) + (y & ~x)) >> 31);
        public static int EqualMask(int x, int y) => ~(x - y | y - x) >> 31;
        public static int LessThanMask(int x, int y) => ((x & ~y) | (~(x ^ y) & (x - y))) >> 31;
        public static int GreaterThanMask(int x, int y) => ((y & ~x) | (~(y ^ x) & (y - x))) >> 31;
        public static int LEqualMask(int x, int y) => ((~(x ^ y) >> 1) + (x & ~y)) >> 31;
        public static int GEqualMask(int x, int y) => ((~(y ^ x) >> 1) + (y & ~x)) >> 31;
        public static sbyte LeftBitShift(sbyte left, int right) => (sbyte)(left << right);
        public static sbyte RightBitShift(sbyte left, int right) => (sbyte)(left >> right);
        public static byte LeftBitShift(byte left, int right) => (byte)(left << right);
        public static byte RightBitShift(byte left, int right) => (byte)(left >> right);
        public static short LeftBitShift(short left, int right) => (short)(left << right);
        public static short RightBitShift(short left, int right) => (short)(left >> right);
        public static ushort LeftBitShift(ushort left, int right) => (ushort)(left << right);
        public static ushort RightBitShift(ushort left, int right) => (ushort)(left >> right);
        public static int ToggleBits(int x, int n) => x ^ (0x1 << n);
        public static uint ToggleBits(uint x, int n) => x ^ (0x1u << n);
        public static long ToggleBits(long x, int n) => x ^ (0x1L << n);
        public static ulong ToggleBits(ulong x, int n) => x ^ (0x1UL << n);
        public static int RotateBitsToLeft(int x, int n) => (x << n) | (x >> (0x20 - n));
        public static uint RotateBitsToLeft(uint x, int n) => (x << n) | (x >> (0x20 - n));
        public static long RotateBitsToLeft(long x, int n) => (x << n) | (x >> (0x40 - n));
        public static ulong RotateBitsToLeft(ulong x, int n) => (x << n) | (x >> (0x40 - n));
        public static int RotateBitsToRight(int x, int n) => (x >> n) | (x << (0x20 - n));
        public static uint RotateBitsToRight(uint x, int n) => (x >> n) | (x << (0x20 - n));
        public static long RotateBitsToRight(long x, int n) => (x >> n) | (x << (0x40 - n));
        public static ulong RotateBitsToRight(ulong x, int n) => (x >> n) | (x << (0x40 - n));
        public static int CountTrailingZeros(sbyte x)
        {
            if (x == 0x0)
                return 0x8;
            x = (sbyte)(x & (uint)-x);
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(ushort x)
        {
            if (x == 0x0)
                return 0x10;
            x = (ushort)(x & (uint)-x);
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(uint x)
        {
            if (x == 0x0)
                return 0x20;
            x &= (uint)-x;
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(ulong x)
        {
            if (x == 0x0)
                return 0x40;
            x = x & (ulong)-(long)x;
            uint xl = (uint)x;
            uint bits = xl != 0x0 ? xl : (uint)(x >> 0x20);
            int offset = xl != 0x0 ? 0x3FF : 0x3DF;
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + bits) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - offset;
        }
        public static int CountTrailingZeros(byte x)
        {
            if (x == 0x0)
                return 0x8;
            x = (byte)(x & (uint)-x);
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(short x)
        {
            if (x == 0x0)
                return 0x10;
            x = (short)(x & (uint)-x);
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(int x)
        {
            if (x == 0x0)
                return 0x20;
            x &= -x;
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - 0x3FF;
        }
        public static int CountTrailingZeros(long x)
        {
            if (x == 0x0)
                return 0x40;
            x = (x & -x);
            uint xl = (uint)x;
            uint bits = xl != 0x0 ? xl : (uint)(x >> 0x20);
            int offset = xl != 0x0 ? 0x3FF : 0x3DF;
            return (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + bits) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34) - offset;
        }
        public static int CountLeadingZeros(uint x)
        {
            if (x == 0)
                return 0x20;
            return 0x41E - (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + x) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34);
        }
        public static int CountLeadingZeros(ulong x)
        {
            if (x == 0x0)
                return 0x40;
            uint xh = (uint)(x >> 0x20);
            uint bits = xh != 0x0 ? xh : (uint)x;
            int offset = xh != 0x0 ? 0x41E : 0x43E;
            return offset - (int)(GetLongFromDoubleBits(GetDoubleFromLongBits(0x4330000000000000L + bits) - GetDoubleFromLongBits(0x4330000000000000L)) >> 0x34);
        }
        public static int CountOnes(sbyte a)
        {
            int x = a;
            x = x - ((x >> 0x1) & 0x55);
            x = (x & 0x33) + ((x >> 0x2) & 0x33);
            return (((x + (x >> 0x4)) & 0x0F) * 0x01) >> 0x6;
        }
        public static int CountOnes(byte a)
        {
            int x = a;
            x = x - ((x >> 0x1) & 0x55);
            x = (x & 0x33) + ((x >> 0x2) & 0x33);
            return (((x + (x >> 0x4)) & 0x0F) * 0x01) >> 0x6;
        }
        public static int CountOnes(short a)
        {
            int x = a;
            x = x - ((x >> 0x1) & 0x5555);
            x = (x & 0x3333) + ((x >> 0x2) & 0x3333);
            return (((x + (x >> 0x4)) & 0x0F0F) * 0x0101) >> 0xc;
        }
        public static int CountOnes(ushort a)
        {
            int x = a;
            x = x - ((x >> 0x1) & 0x5555);
            x = (x & 0x3333) + ((x >> 0x2) & 0x3333);
            return (((x + (x >> 0x4)) & 0x0F0F) * 0x0101) >> 0xc;
        }
        public static int CountOnes(int x)
        {
            x = x - ((x >> 0x1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 0x2) & 0x33333333);
            return (((x + (x >> 0x4)) & 0x0F0F0F0F) * 0x01010101) >> 0x18;
        }
        public static int CountOnes(uint x)
        {
            x = x - ((x >> 0x1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 0x2) & 0x33333333);
            return (int)((((x + (x >> 0x4)) & 0x0F0F0F0F) * 0x01010101) >> 0x18);
        }
        public static int CountOnes(ulong x)
        {
            x = x - ((x >> 0x1) & 0x5555555555555555);
            x = (x & 0x3333333333333333) + ((x >> 0x2) & 0x3333333333333333);
            return (int)((((x + (x >> 0x4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 0x38);
        }
        public static int CountOnes(long x)
        {
            x = x - ((x >> 0x1) & 0x5555555555555555);
            x = (x & 0x3333333333333333) + ((x >> 0x2) & 0x3333333333333333);
            return (int)((((x + (x >> 0x4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 0x38);
        }
        public static float GetFloatFromIntBits(int valueToGet)
        {
            IntToFloat i;
            i.floatValue = 0f;
            i.intValue = valueToGet;
            return i.floatValue;
        }
        public static int GetIntFromFloatBits(float valueToGet)
        {
            IntToFloat i;
            i.intValue = 0;
            i.floatValue = valueToGet;
            return i.intValue;
        }
        public static float GetFloatFromUintBits(uint valueToGet)
        {
            IntToFloat i;
            i.floatValue = 0f;
            i.intValue = (int)valueToGet;
            return i.floatValue;
        }
        public static uint GetUintFromFloatBits(float valueToGet)
        {
            IntToFloat i;
            i.intValue = 0;
            i.floatValue = valueToGet;
            return (uint)i.intValue;
        }
        public static double GetDoubleFromLongBits(long valueToGet)
        {
            LongToDouble i;
            i.doubleValue = 0d;
            i.longValue = valueToGet;
            return i.doubleValue;
        }
        public static long GetLongFromDoubleBits(double valueToGet)
        {
            LongToDouble i;
            i.longValue = 0L;
            i.doubleValue = valueToGet;
            return i.longValue;
        }
        public static double GetDoubleFromUlongBits(ulong valueToGet)
        {
            LongToDouble i;
            i.doubleValue = 0d;
            i.longValue = (long)valueToGet;
            return i.doubleValue;
        }
        public static ulong GetUlongFromDoubleBits(double valueToGet)
        {
            LongToDouble i;
            i.longValue = 0L;
            i.doubleValue = valueToGet;
            return (ulong)i.longValue;
        }
        public static sbyte SetBoolOn(sbyte value, bool valueToSet, int bitToSet) => (sbyte)((value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1 : 0x0) << bitToSet));
        public static bool GetBoolFrom(sbyte value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static byte SetBoolOn(byte value, bool valueToSet, int bitToSet) => (byte)((value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1 : 0x0) << bitToSet));
        public static bool GetBoolFrom(byte value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static short SetBoolOn(short value, bool valueToSet, int bitToSet) => (short)((value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1 : 0x0) << bitToSet));
        public static short SetSbyteOn(short value, sbyte valueToSet, int bitToSet) => (short)((value & ~(0xff << bitToSet)) | (valueToSet << bitToSet));
        public static short SetByteOn(short value, byte valueToSet, int bitToSet) => (short)((value & ~(0xff << bitToSet)) | (valueToSet << bitToSet));
        public static bool GetBoolFrom(short value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static sbyte GetSbyteFrom(short valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(short valueToGet, int bitToGet) => (byte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static ushort SetBoolOn(ushort value, bool valueToSet, int bitToSet) => (ushort)((value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1 : 0x0) << bitToSet));
        public static ushort SetSbyteOn(ushort value, sbyte valueToSet, int bitToSet) => (ushort)((value & ~(0xff << bitToSet)) | (valueToSet << bitToSet));
        public static ushort SetByteOn(ushort value, byte valueToSet, int bitToSet) => (ushort)((value & ~(0xff << bitToSet)) | (valueToSet << bitToSet));
        public static bool GetBoolFrom(ushort value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static sbyte GetSbyteFrom(ushort valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xffu << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(ushort valueToGet, int bitToGet) => (byte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static int SetBoolOn(int value, bool valueToSet, int bitToSet) => (value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1 : 0x0) << bitToSet);
        public static int SetSbyteOn(int value, sbyte valueToSet, int bitToSet) => (value & ~(0xff << bitToSet)) | (valueToSet << bitToSet);
        public static int SetByteOn(int value, byte valueToSet, int bitToSet) => (value & ~(0xff << bitToSet)) | (valueToSet << bitToSet);
        public static int SetShortOn(int value, short valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | (valueToSet << bitToSet);
        public static int SetUshortOn(int value, ushort valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | (valueToSet << bitToSet);
        public static int SetCharOn(int value, char valueToSet, int bitToSet) => value & ~(0xffff << bitToSet) | (valueToSet << bitToSet);
        public static int SetHalfOn(int value, half valueToSet, int bitToSet) => value & ~(0xffff << bitToSet) | (valueToSet.BitsValues << bitToSet);
        public static bool GetBoolFrom(int value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static sbyte GetSbyteFrom(int valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(int valueToGet, int bitToGet) => (byte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static short GetShortFrom(int valueToGet, int bitToGet) => (short)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static ushort GetUshortFrom(int valueToGet, int bitToGet) => (ushort)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static char GetCharFrom(int valueToGet, int bitToGet) => (char)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static half GetHalfFrom(int valueToGet, int bitToGet)
        {
            half h;
            h.BitsValues = (ushort)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
            return h;
        }
        public static uint SetBoolOn(uint value, bool valueToSet, int bitToSet) => (value & ~(0x1u << bitToSet)) | ((valueToSet ? 0x1u : 0x0u) << bitToSet);
        public static uint SetSbyteOn(uint value, sbyte valueToSet, int bitToSet) => (value & ~(0xffu << bitToSet)) | ((uint)valueToSet << bitToSet);
        public static uint SetByteOn(uint value, byte valueToSet, int bitToSet) => (value & ~(0xffu << bitToSet)) | ((uint)valueToSet << bitToSet);
        public static uint SetShortOn(uint value, short valueToSet, int bitToSet) => (value & ~(0xffffu << bitToSet)) | ((uint)valueToSet << bitToSet);
        public static uint SetUshortOn(uint value, ushort valueToSet, int bitToSet) => (value & ~(0xffffu << bitToSet)) | ((uint)valueToSet << bitToSet);
        public static uint SetCharOn(uint value, char valueToSet, int bitToSet) => (value & ~(0xffffu << bitToSet)) | ((uint)valueToSet << bitToSet);
        public static uint SetHalfOn(uint value, half valueToSet, int bitToSet) => (value & ~(0xffffu << bitToSet)) | ((uint)valueToSet.BitsValues << bitToSet);
        public static bool GetBoolFrom(uint value, int bitToGet) => (value & (0x1u << bitToGet)) == (0x1 << bitToGet);
        public static sbyte GetSbyteFrom(uint valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xffu << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(uint valueToGet, int bitToGet) => (byte)((valueToGet & (0xffu << bitToGet)) >> bitToGet);
        public static short GetShortFrom(uint valueToGet, int bitToGet) => (short)((valueToGet & (0xffffu << bitToGet)) >> bitToGet);
        public static ushort GetUshortFrom(uint valueToGet, int bitToGet) => (ushort)((valueToGet & (0xffffu << bitToGet)) >> bitToGet);
        public static char GetCharFrom(uint valueToGet, int bitToGet) => (char)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static half GetHalfFrom(uint valueToGet, int bitToGet)
        {
            half h;
            h.BitsValues = (ushort)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
            return h;
        }
        public static long SetBoolOn(long value, bool valueToSet, int bitToSet) => (value & ~(0x1 << bitToSet)) | ((valueToSet ? 0x1L : 0x0L) << bitToSet);
        public static long SetSbyteOn(long value, sbyte valueToSet, int bitToSet) => (value & ~(0xff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetByteOn(long value, byte valueToSet, int bitToSet) => (value & ~(0xff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetShortOn(long value, short valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetUshortOn(long value, ushort valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetCharOn(long value, char valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetHalfOn(long value, half valueToSet, int bitToSet) => (value & ~(0xffff << bitToSet)) | ((long)valueToSet.BitsValues << bitToSet);
        public static long SetIntOn(long value, short valueToSet, int bitToSet) => (value & ~(0xffffffff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static long SetUIntOn(long value, ushort valueToSet, int bitToSet) => (value & ~(0xffffffff << bitToSet)) | ((long)valueToSet << bitToSet);
        public static bool GetBoolFrom(long value, int bitToGet) => (value & (0x1 << bitToGet)) == (0x1 << bitToGet);
        public static sbyte GetSbyteFrom(long valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(long valueToGet, int bitToGet) => (byte)((valueToGet & (0xff << bitToGet)) >> bitToGet);
        public static short GetShortFrom(long valueToGet, int bitToGet) => (short)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static ushort GetUshortFrom(long valueToGet, int bitToGet) => (ushort)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static char GetCharFrom(long valueToGet, int bitToGet) => (char)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
        public static half GetHalfFrom(long valueToGet, int bitToGet)
        {
            half h;
            h.BitsValues = (ushort)((valueToGet & (0xffff << bitToGet)) >> bitToGet);
            return h;
        }
        public static int GetIntFrom(long valueToGet, int bitToGet) => (int)((valueToGet & (0xffffffff << bitToGet)) >> bitToGet);
        public static uint GetUintFrom(long valueToGet, int bitToGet) => (uint)((valueToGet & (0xffffffff << bitToGet)) >> bitToGet);
        public static ulong SetBoolOn(ulong value, bool valueToSet, int bitToSet) => (value & ~(0x1UL << bitToSet)) | ((valueToSet ? 0x1UL : 0x0UL) << bitToSet);
        public static ulong SetSbyteOn(ulong value, sbyte valueToSet, int bitToSet) => (value & ~(0xffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetByteOn(ulong value, byte valueToSet, int bitToSet) => (value & ~(0xffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetShortOn(ulong value, short valueToSet, int bitToSet) => (value & ~(0xffffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetUshortOn(ulong value, ushort valueToSet, int bitToSet) => (value & ~(0xffffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetCharOn(ulong value, char valueToSet, int bitToSet) => (value & ~(0xffffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetHalfOn(ulong value, half valueToSet, int bitToSet) => (value & ~(0xffffUL << bitToSet)) | ((ulong)valueToSet.BitsValues << bitToSet);
        public static ulong SetIntOn(ulong value, short valueToSet, int bitToSet) => (value & ~(0xffffffffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static ulong SetUIntOn(ulong value, ushort valueToSet, int bitToSet) => (value & ~(0xffffffffUL << bitToSet)) | ((ulong)valueToSet << bitToSet);
        public static bool GetBoolFrom(ulong value, int bitToGet) => (value & (0x1UL << bitToGet)) == (0x1UL << bitToGet);
        public static sbyte GetSbyteFrom(ulong valueToGet, int bitToGet) => (sbyte)((valueToGet & (0xffUL << bitToGet)) >> bitToGet);
        public static byte GetByteFrom(ulong valueToGet, int bitToGet) => (byte)((valueToGet & (0xffUL << bitToGet)) >> bitToGet);
        public static short GetShortFrom(ulong valueToGet, int bitToGet) => (short)((valueToGet & (0xffffUL << bitToGet)) >> bitToGet);
        public static ushort GetUshortFrom(ulong valueToGet, int bitToGet) => (ushort)((valueToGet & (0xffffUL << bitToGet)) >> bitToGet);
        public static char GetCharFrom(ulong valueToGet, int bitToGet) => (char)((valueToGet & (0xffffUL << bitToGet)) >> bitToGet);
        public static half GetHalfFrom(ulong valueToGet, int bitToGet)
        {
            half h;
            h.BitsValues = (ushort)((valueToGet & (0xffffUL << bitToGet)) >> bitToGet);
            return h;
        }
        public static int GetIntFrom(ulong valueToGet, int bitToGet) => (int)((valueToGet & (0xffffffffUL << bitToGet)) >> bitToGet);
        public static uint GetUintFrom(ulong valueToGet, int bitToGet) => (uint)((valueToGet & (0xffffffffUL << bitToGet)) >> bitToGet);
        public static sbyte SetOn(sbyte value, sbyte valueToSet, int bitToSet, int sizeOf) => (sbyte)((value & ~(((0x1 << sizeOf) - 0x1) << bitToSet)) | (valueToSet << bitToSet));
        public static sbyte GetFrom(sbyte valueToGet, int bitToGet, int sizeOf) => (sbyte)((valueToGet & (((0x1 << sizeOf) - 0x1) << bitToGet)) >> bitToGet);
        public static byte SetOn(byte value, byte valueToSet, int bitToSet, int sizeOf) => (byte)((value & ~(((0x1 << sizeOf) - 0x1) << bitToSet)) | (valueToSet << bitToSet));
        public static byte GetFrom(byte valueToGet, int bitToGet, int sizeOf) => (byte)((valueToGet & (((0x1 << sizeOf) - 0x1) << bitToGet)) >> bitToGet);
        public static short SetOn(short value, short valueToSet, int bitToSet, int sizeOf) => (short)((value & ~(((0x1 << sizeOf) - 0x1) << bitToSet)) | (valueToSet << bitToSet));
        public static short GetFrom(short valueToGet, int bitToGet, int sizeOf) => (short)((valueToGet & (((0x1 << sizeOf) - 0x1) << bitToGet)) >> bitToGet);
        public static ushort SetOn(ushort value, ushort valueToSet, int bitToSet, int sizeOf) => (ushort)((value & ~(((0x1 << sizeOf) - 0x1) << bitToSet)) | (valueToSet << bitToSet));
        public static ushort GetFrom(ushort valueToGet, int bitToGet, int sizeOf) => (ushort)((valueToGet & (((0x1 << sizeOf) - 0x1) << bitToGet)) >> bitToGet);
        public static int SetOn(int value, int valueToSet, int bitToSet, int sizeOf) => (value & ~(((0x1 << sizeOf) - 0x1) << bitToSet)) | (valueToSet << bitToSet);
        public static int GetFrom(int valueToGet, int bitToGet, int sizeOf) => ((valueToGet & (((0x1 << sizeOf) - 0x1) << bitToGet)) >> bitToGet);
        public static uint SetOn(uint value, uint valueToSet, int bitToSet, int sizeOf) => (value & ~(((0x1u << sizeOf) - 0x1u) << bitToSet)) | (valueToSet << bitToSet);
        public static uint GetFrom(uint valueToGet, int bitToGet, int sizeOf) => ((valueToGet & (((0x1u << sizeOf) - 0x1u) << bitToGet)) >> bitToGet);
        public static long SetOn(long value, long valueToSet, int bitToSet, int sizeOf) => (value & ~(((0x1L << sizeOf) - 0x1L) << bitToSet)) | (valueToSet << bitToSet);
        public static long GetFrom(long valueToGet, int bitToGet, int sizeOf) => ((valueToGet & (((0x1L << sizeOf) - 0x1L) << bitToGet)) >> bitToGet);
        public static ulong SetOn(ulong value, ulong valueToSet, int bitToSet, int sizeOf) => (value & ~(((0x1UL << sizeOf) - 0x1UL) << bitToSet)) | (valueToSet << bitToSet);
        public static ulong GetFrom(ulong valueToGet, int bitToGet, int sizeOf) => ((valueToGet & (((0x1UL << sizeOf) - 0x1UL) << bitToGet)) >> bitToGet);
        public static sbyte SelectorSbyte(int bitsLength) => (sbyte)((0x1 << bitsLength) - 0x1);
        public static byte SelectorByte(int bitsLength) => (byte)((0x1 << bitsLength) - 0x1);
        public static short SelectorShort(int bitsLength) => (short)((0x1 << bitsLength) - 0x1);
        public static ushort SelectorUshort(int bitsLength) => (ushort)((0x1 << bitsLength) - 0x1);
        public static int SelectorInt(int bitsLength) => (0x1 << bitsLength) - 0x1;
        public static uint SelectorUint(int bitsLength) => (0x1u << bitsLength) - 0x1u;
        public static long SelectorLong(int bitsLength) => (0x1L << bitsLength) - 0x1L;
        public static ulong SelectorUlong(int bitsLength) => (0x1ul << bitsLength) - 0x1ul;
        public static sbyte BinMaskIfBitSet(sbyte a, int bitPos) => (sbyte)(((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31);
        public static byte BinMaskIfBitSet(byte a, int bitPos) => (byte)(((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31);
        public static short BinMaskIfBitSet(short a, int bitPos) => (short)(((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31);
        public static ushort BinMaskIfBitSet(ushort a, int bitPos) => (ushort)(((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31);
        public static int BinMaskIfBitSet(int a, int bitPos) => ((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31;
        public static uint BinMaskIfBitSet(uint a, int bitPos) => (uint)((a & (0x1 << bitPos)) << (31 - bitPos)) >> 31;
        public static long BinMaskIfBitSet(long a, int bitPos) => ((a & (0x1L << bitPos)) << (63 - bitPos)) >> 63;
        public static ulong BinMaskIfBitSet(ulong a, int bitPos) => ((a & (0x1Ul << bitPos)) << (63 - bitPos)) >> 63;
    }
}
