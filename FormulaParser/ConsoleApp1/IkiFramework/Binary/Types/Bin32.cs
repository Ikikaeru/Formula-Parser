using System;
namespace IkiCore.Binary
{
    [Serializable]
    public struct Bin32 : IEquatable<Bin32>, IFormattable
    {
        int value;
        public Bin32(sbyte value)
        {
            this.value = value;
        }
        public Bin32(byte value)
        {
            this.value = value;
        }
        public Bin32(short value)
        {
            this.value = value;
        }
        public Bin32(ushort value)
        {
            this.value = value;
        }
        public Bin32(int value)
        {
            this.value = value;
        }
        public Bin32(uint value)
        {
            this.value = (int)value;
        }
        public Bin32(long value)
        {
            this.value = (int)value;
        }
        public Bin32(ulong value)
        {
            this.value = (int)value;
        }
        public bool GetBool(BinIntIndex index)
        {
            return (value & (int)index) == (int)index;
        }
        public void SetBool(BinIntIndex index)
        {
            value |= (int)index;
        }
        /// <summary>
        /// Set a value of 3 differents states (0 => 2) at index [0 => 15].
        /// </summary>
        /// <param name="state"></param>
        /// <param name="index"></param>
        public void SetTrinary(StatementState state, int index)
        {

            if (index > 0xF || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            value = ((int)state << (index << 0x1)) | value;
        }
        /// <summary>
        /// Get a value of 3 differents states (0 => 2) at index [0 => 15].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public StatementState GetTrinary(int index)
        {
            if (index > 0xF || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (StatementState)((value >> (index << 0x1)) & 0x3);
        }
        /// <summary>
        /// Set a value of 16 differents states (0 => 15) at index [0 => 7].
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void SetHexaDecimal(HexaDecimal value, int index)
        {
            if (index > 0x7 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            this.value = (((int)value & 0xF) << (index << 0x4)) | this.value;
        }
        /// <summary>
        /// Get a value of 16 differents states (0 => 15) at index [0 => 7].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public HexaDecimal GetHexaDecimal(int index)
        {
            if (index > 0x7 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (HexaDecimal)((value >> (index << 0x4)) & 0xF);
        }
        public static explicit operator Bin32(sbyte v)
        {
            Bin32 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin32(byte v)
        {
            Bin32 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin32(short v)
        {
            Bin32 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin32(ushort v)
        {
            Bin32 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin32(int v)
        {
            Bin32 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin32(uint v)
        {
            Bin32 bb;
            bb.value = (int)v;
            return bb;
        }
        public static explicit operator Bin32(long v)
        {
            Bin32 bb;
            bb.value = (int)v;
            return bb;
        }
        public static explicit operator Bin32(ulong v)
        {
            Bin32 bb;
            bb.value = (int)v;
            return bb;
        }
        public static explicit operator sbyte(Bin32 v) => (sbyte)v.value;
        public static explicit operator byte(Bin32 v) => (byte)v.value;
        public static explicit operator short(Bin32 v) => (short)v.value;
        public static explicit operator ushort(Bin32 v) => (ushort)v.value;
        public static explicit operator int(Bin32 v) => v.value;
        public static explicit operator uint(Bin32 v) => (uint)v.value;
        public static explicit operator long(Bin32 v) => v.value;
        public static explicit operator ulong(Bin32 v) => (ulong)v.value;
        bool IEquatable<Bin32>.Equals(Bin32 other)
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
        public static Bin32 operator ~(Bin32 a)
        {
            a.value = ~a.value;
            return a;
        }
        public static Bin32 operator ++(Bin32 a)
        {
            a.value += 0x1;
            return a;
        }
        public static Bin32 operator --(Bin32 a)
        {
            a.value -= 0x1;
            return a;
        }
        public static Bin32 operator +(Bin32 a, Bin32 b)
        {
            a.value += b.value;
            return a;
        }
        public static Bin32 operator -(Bin32 a, Bin32 b)
        {
            a.value -= b.value;
            return a;
        }
        public static Bin32 operator *(Bin32 a, Bin32 b)
        {
            a.value *= b.value;
            return a;
        }
        public static Bin32 operator /(Bin32 a, Bin32 b)
        {
            a.value /= b.value;
            return a;
        }
        public static Bin32 operator %(Bin32 a, Bin32 b)
        {
            a.value %= b.value;
            return a;
        }
        public static Bin32 operator &(Bin32 a, Bin32 b)
        {
            a.value &= b.value;
            return a;
        }
        public static Bin32 operator |(Bin32 a, Bin32 b)
        {
            a.value |= b.value;
            return a;
        }
        public static Bin32 operator ^(Bin32 a, Bin32 b)
        {
            a.value ^= b.value;
            return a;
        }
        public static Bin32 operator <<(Bin32 a, int i)
        {
            a.value <<= i;
            return a;
        }
        public static Bin32 operator >>(Bin32 a, int i)
        {
            a.value >>= i;
            return a;
        }
        public static bool operator <(Bin32 a, Bin32 b) => a.value < b.value;
        public static bool operator >(Bin32 a, Bin32 b) => a.value > b.value;
        public static bool operator <=(Bin32 a, Bin32 b) => a.value <= b.value;
        public static bool operator >=(Bin32 a, Bin32 b) => a.value >= b.value;
        public static bool operator ==(Bin32 a, Bin32 b) => a.value == b.value;
        public static bool operator !=(Bin32 a, Bin32 b) => a.value != b.value;
    }
}
