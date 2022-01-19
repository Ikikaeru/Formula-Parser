using System;
namespace IkiCore.Binary
{
    [Serializable]
    public struct Bin64 : IEquatable<Bin64>, IFormattable
    {
        long value;
        public Bin64(sbyte value)
        {
            this.value = value;
        }
        public Bin64(byte value)
        {
            this.value = value;
        }
        public Bin64(short value)
        {
            this.value = value;
        }
        public Bin64(ushort value)
        {
            this.value = value;
        }
        public Bin64(int value)
        {
            this.value = value;
        }
        public Bin64(uint value)
        {
            this.value = value;
        }
        public Bin64(long value)
        {
            this.value = value;
        }
        public Bin64(ulong value)
        {
            this.value = (long)value;
        }
        public bool GetBool(BinLongIndex index)
        {
            return (value & (int)index) == (int)index;
        }
        public void SetBool(BinLongIndex index)
        {
            value |= (long)index;
        }
        /// <summary>
        /// Set a value of 3 differents states (0 => 2) at index [0 => 31].
        /// </summary>
        /// <param name="state"></param>
        /// <param name="index"></param>
        public void SetTrinary(StatementState state, int index)
        {

            if (index > 0x1F || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            value = ((long)state << (index << 0x1)) | value;
        }
        /// <summary>
        /// Get a value of 3 differents states (0 => 2) at index [0 => 31].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public StatementState GetTrinary(int index)
        {
            if (index > 0x1F || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (StatementState)((value >> (index << 0x1)) & 0x3);
        }
        /// <summary>
        /// Set a value of 16 differents states (0 => 15) at index [0 => 15].
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void SetHexaDecimal(HexaDecimal value, int index)
        {
            if (index > 0xF || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            this.value = (((long)value & 0xFL) << (index << 0x4)) | this.value;
        }
        /// <summary>
        /// Get a value of 16 differents states (0 => 15) at index [0 => 15].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public HexaDecimal GetHexaDecimal(int index)
        {
            if (index > 0xF || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (HexaDecimal)((value >> (index << 0x4)) & 0xF);
        }
        public static explicit operator Bin64(sbyte v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(byte v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(short v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(ushort v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(int v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(uint v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(long v)
        {
            Bin64 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin64(ulong v)
        {
            Bin64 bb;
            bb.value = (long)v;
            return bb;
        }
        public static explicit operator sbyte(Bin64 v) => (sbyte)v.value;
        public static explicit operator byte(Bin64 v) => (byte)v.value;
        public static explicit operator short(Bin64 v) => (short)v.value;
        public static explicit operator ushort(Bin64 v) => (ushort)v.value;
        public static explicit operator int(Bin64 v) => (int)v.value;
        public static explicit operator uint(Bin64 v) => (uint)v.value;
        public static explicit operator long(Bin64 v) => v.value;
        public static explicit operator ulong(Bin64 v) => (ulong)v.value;
        bool IEquatable<Bin64>.Equals(Bin64 other)
        {
            return other.value == value;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format(value.ToString(), formatProvider);
        }
        public static Bin64 operator ~(Bin64 a)
        {
            a.value = ~a.value;
            return a;
        }
        public static Bin64 operator ++(Bin64 a)
        {
            a.value += 0x1L;
            return a;
        }
        public static Bin64 operator --(Bin64 a)
        {
            a.value -= 0x1L;
            return a;
        }
        public static Bin64 operator +(Bin64 a, Bin64 b)
        {
            a.value += b.value;
            return a;
        }
        public static Bin64 operator -(Bin64 a, Bin64 b)
        {
            a.value -= b.value;
            return a;
        }
        public static Bin64 operator *(Bin64 a, Bin64 b)
        {
            a.value *= b.value;
            return a;
        }
        public static Bin64 operator /(Bin64 a, Bin64 b)
        {
            a.value /= b.value;
            return a;
        }
        public static Bin64 operator %(Bin64 a, Bin64 b)
        {
            a.value %= b.value;
            return a;
        }
        public static Bin64 operator &(Bin64 a, Bin64 b)
        {
            a.value &= b.value;
            return a;
        }
        public static Bin64 operator |(Bin64 a, Bin64 b)
        {
            a.value |= b.value;
            return a;
        }
        public static Bin64 operator ^(Bin64 a, Bin64 b)
        {
            a.value ^= b.value;
            return a;
        }
        public static Bin64 operator <<(Bin64 a, int i)
        {
            a.value <<= i;
            return a;
        }
        public static Bin64 operator >>(Bin64 a, int i)
        {
            a.value >>= i;
            return a;
        }
        public static bool operator <(Bin64 a, Bin64 b) => a.value < b.value;
        public static bool operator >(Bin64 a, Bin64 b) => a.value > b.value;
        public static bool operator <=(Bin64 a, Bin64 b) => a.value <= b.value;
        public static bool operator >=(Bin64 a, Bin64 b) => a.value >= b.value;
        public static bool operator ==(Bin64 a, Bin64 b) => a.value == b.value;
        public static bool operator !=(Bin64 a, Bin64 b) => a.value != b.value;
    }
}
