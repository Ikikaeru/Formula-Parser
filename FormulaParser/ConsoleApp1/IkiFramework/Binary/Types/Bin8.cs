using System;
namespace IkiCore.Binary
{
    [Serializable]
    public struct Bin8 : IEquatable<Bin8>, IFormattable
    {
        byte value;
        public Bin8(sbyte value)
        {
            this.value = (byte)value;
        }
        public Bin8(byte value)
        {
            this.value = value;
        }
        public Bin8(short value)
        {
            this.value = (byte)value;
        }
        public Bin8(ushort value)
        {
            this.value = (byte)value;
        }
        public Bin8(int value)
        {
            this.value = (byte)value;
        }
        public Bin8(uint value)
        {
            this.value = (byte)value;
        }
        public Bin8(long value)
        {
            this.value = (byte)value;
        }
        public Bin8(ulong value)
        {
            this.value = (byte)value;
        }
        public bool GetBool(BinByteIndex index)
        {
            return (value & (int)index) == (int)index;
        }
        public void SetBool(BinByteIndex index)
        {
            value = (byte)(value | (int)index);
        }
        /// <summary>
        /// Set a value of 3 differents states (0 => 2) at index [0 => 3] to get the value stored at [7,6][i = 3] [5,4][i = 2] [3,2][i = 1] [1,0][i = 0].
        /// </summary>
        /// <param name="state"></param>
        /// <param name="index"></param>
        public void SetTrinary(StatementState state, int index)
        {

            if (index > 0x3 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            value = (byte)(((int)state << (index << 0x1)) | value);
        }
        /// <summary>
        /// Get a value of 3 differents states (0 => 2) at index [0 => 3] to get the value stored at [7,6][i = 3] [5,4][i = 2] [3,2][i = 1] [1,0][i = 0].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public StatementState GetTrinary(int index)
        {
            if (index > 0x3 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (StatementState)((value >> (index << 0x1)) & 0x3);
        }
        /// <summary>
        /// Set a value of 16 differents states (0 => 16) at index [0 => 1] to get the value stored at [7,6,5,4][i = 1] [3,2,1,0][i = 0].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void SetHexaDecimal(HexaDecimal value, int index)
        {
            if (index > 0x1 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            this.value = (byte)((((int)value & 0xF) << (index << 0x4)) | this.value);
        }
        /// <summary>
        /// Get a value of 16 differents states (0 => 16) at index [0 => 1] to get the value stored at [7,6,5,4][i = 1] [3,2,1,0][i = 0].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public HexaDecimal GetHexaDecimal(int index)
        {
            if (index > 0x1 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (HexaDecimal)((value >> (index << 0x4)) & 0xF);
        }
        public static explicit operator Bin8(sbyte v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(byte v)
        {
            Bin8 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin8(short v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(ushort v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(int v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(uint v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(long v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator Bin8(ulong v)
        {
            Bin8 bb;
            bb.value = (byte)v;
            return bb;
        }
        public static explicit operator sbyte(Bin8 v) => (sbyte)v.value;
        public static explicit operator byte(Bin8 v) => v.value;
        public static explicit operator short(Bin8 v) => v.value;
        public static explicit operator ushort(Bin8 v) => v.value;
        public static explicit operator int(Bin8 v) => v.value;
        public static explicit operator uint(Bin8 v) => v.value;
        public static explicit operator long(Bin8 v) => v.value;
        public static explicit operator ulong(Bin8 v) => v.value;
        bool IEquatable<Bin8>.Equals(Bin8 other)
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
        public static Bin8 operator ~(Bin8 a)
        {
            a.value = (byte)~a.value;
            return a;
        }
        public static Bin8 operator ++(Bin8 a)
        {
            a.value = (byte)(a.value + 0x1);
            return a;
        }
        public static Bin8 operator --(Bin8 a)
        {
            a.value = (byte)(a.value - 0x1);
            return a;
        }
        public static Bin8 operator +(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value + b.value);
            return a;
        }
        public static Bin8 operator -(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value - b.value);
            return a;
        }
        public static Bin8 operator *(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value * b.value);
            return a;
        }
        public static Bin8 operator /(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value / b.value);
            return a;
        }
        public static Bin8 operator %(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value % b.value);
            return a;
        }
        public static Bin8 operator &(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value & b.value);
            return a;
        }
        public static Bin8 operator |(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value | b.value);
            return a;
        }
        public static Bin8 operator ^(Bin8 a, Bin8 b)
        {
            a.value = (byte)(a.value ^ b.value);
            return a;
        }
        public static Bin8 operator <<(Bin8 a, int i)
        {
            a.value = (byte)(a.value << i);
            return a;
        }
        public static Bin8 operator >>(Bin8 a, int i)
        {
            a.value = (byte)(a.value >> i);
            return a;
        }
        public static bool operator <(Bin8 a, Bin8 b) => a.value < b.value;
        public static bool operator >(Bin8 a, Bin8 b) => a.value > b.value;
        public static bool operator <=(Bin8 a, Bin8 b) => a.value <= b.value;
        public static bool operator >=(Bin8 a, Bin8 b) => a.value >= b.value;
        public static bool operator ==(Bin8 a, Bin8 b) => a.value == b.value;
        public static bool operator !=(Bin8 a, Bin8 b) => a.value != b.value;
    }
}
