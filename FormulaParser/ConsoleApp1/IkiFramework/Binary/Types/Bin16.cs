using System;
namespace IkiCore.Binary
{
    [Serializable]
    public struct Bin16 : IEquatable<Bin16>, IFormattable
    {
        short value;
        public Bin16(sbyte value)
        {
            this.value = value;
        }
        public Bin16(byte value)
        {
            this.value = value;
        }
        public Bin16(short value)
        {
            this.value = value;
        }
        public Bin16(ushort value)
        {
            this.value = (short)value;
        }
        public Bin16(int value)
        {
            this.value = (short)value;
        }
        public Bin16(uint value)
        {
            this.value = (short)value;
        }
        public Bin16(long value)
        {
            this.value = (short)value;
        }
        public Bin16(ulong value)
        {
            this.value = (short)value;
        }
        public bool GetBool(BinShortIndex index)
        {
            return (value & (int)index) == (int)index;
        }
        public void SetBool(BinShortIndex index)
        {
            value = (short)((int)value | (int)index);
        }
        /// <summary>
        /// Set a value of 3 differents states (0 => 2) at index [0 => 7] to get the value stored at [7,6][i = 3] [5,4][i = 2] [3,2][i = 1] [1,0][i = 0].
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void SetTrinary(StatementState state, int index)
        {
            if (index > 0x7 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            value = (short)(((int)state << (index << 0x1)) | (int)value);
        }
        /// <summary>
        /// Get a value of 3 differents states (0 => 2) at index [0 => 7] to get the value stored at [7,6][i = 3] [5,4][i = 2] [3,2][i = 1] [1,0][i = 0].
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public StatementState GetTrinary(int index)
        {
            if (index > 0x7 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (StatementState)((value >> (index << 0x1)) & 0x3);
        }
        /// <summary>
        /// Set a value of 16 differents states (0 => 16) at index [0 => 3] to get the value stored at [7,6,5,4][i = 1] [3,2,1,0][i = 0].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void SetHexaDecimal(HexaDecimal value, int index)
        {
            if (index > 0x3 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            this.value = (short)((((int)value & 0xF) << (index << 0x4)) | (int)this.value);
        }
        /// <summary>
        /// Get a value of 16 differents states (0 => 16) at index [0 => 3] to get the value stored at [7,6,5,4][i = 1] [3,2,1,0][i = 0].
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public HexaDecimal GetHexaDecimal(int index)
        {
            if (index > 0x3 || index < 0x0)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            return (HexaDecimal)((value >> (index << 0x4)) & 0xF);
        }
        public static explicit operator Bin16(sbyte v)
        {
            Bin16 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin16(byte v)
        {
            Bin16 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin16(short v)
        {
            Bin16 bb;
            bb.value = v;
            return bb;
        }
        public static explicit operator Bin16(ushort v)
        {
            Bin16 bb;
            bb.value = (short)v;
            return bb;
        }
        public static explicit operator Bin16(int v)
        {
            Bin16 bb;
            bb.value = (short)v;
            return bb;
        }
        public static explicit operator Bin16(uint v)
        {
            Bin16 bb;
            bb.value = (short)v;
            return bb;
        }
        public static explicit operator Bin16(long v)
        {
            Bin16 bb;
            bb.value = (short)v;
            return bb;
        }
        public static explicit operator Bin16(ulong v)
        {
            Bin16 bb;
            bb.value = (short)v;
            return bb;
        }
        public static explicit operator sbyte(Bin16 v) => (sbyte)v.value;
        public static explicit operator byte(Bin16 v) => (byte)v.value;
        public static explicit operator short(Bin16 v) => v.value;
        public static explicit operator ushort(Bin16 v) => (ushort)v.value;
        public static explicit operator int(Bin16 v) => v.value;
        public static explicit operator uint(Bin16 v) => (uint)v.value;
        public static explicit operator long(Bin16 v) => v.value;
        public static explicit operator ulong(Bin16 v) => (ulong)v.value;
        bool IEquatable<Bin16>.Equals(Bin16 other)
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
        public static Bin16 operator ~(Bin16 a)
        {
            a.value = (short)~a.value;
            return a;
        }
        public static Bin16 operator ++(Bin16 a)
        {
            a.value = (short)(a.value + 0x1);
            return a;
        }
        public static Bin16 operator --(Bin16 a)
        {
            a.value = (short)(a.value - 0x1);
            return a;
        }
        public static Bin16 operator +(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value + b.value);
            return a;
        }
        public static Bin16 operator -(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value - b.value);
            return a;
        }
        public static Bin16 operator *(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value * b.value);
            return a;
        }
        public static Bin16 operator /(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value / b.value);
            return a;
        }
        public static Bin16 operator %(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value % b.value);
            return a;
        }
        public static Bin16 operator &(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value & b.value);
            return a;
        }
        public static Bin16 operator |(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value | b.value);
            return a;
        }
        public static Bin16 operator ^(Bin16 a, Bin16 b)
        {
            a.value = (short)(a.value ^ b.value);
            return a;
        }
        public static Bin16 operator <<(Bin16 a, int i)
        {
            a.value = (short)(a.value << i);
            return a;
        }
        public static Bin16 operator >>(Bin16 a, int i)
        {
            a.value = (short)(a.value >> i);
            return a;
        }
        public static bool operator <(Bin16 a, Bin16 b) => a.value < b.value;
        public static bool operator >(Bin16 a, Bin16 b) => a.value > b.value;
        public static bool operator <=(Bin16 a, Bin16 b) => a.value <= b.value;
        public static bool operator >=(Bin16 a, Bin16 b) => a.value >= b.value;
        public static bool operator ==(Bin16 a, Bin16 b) => a.value == b.value;
        public static bool operator !=(Bin16 a, Bin16 b) => a.value != b.value;
    }
}
