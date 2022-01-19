using System;
using System.Xml.Serialization;
using IkiCore.Binary;
namespace IkiCore
{
    [Serializable]
	public struct half : IEquatable<half>, IFormattable
    {
        public ushort BitsValues;
        public half(half a)
        {
            BitsValues = a.BitsValues;
        }
        public half(double a)
        {
            const int infinity_32 = 255 << 23;
            uint ux = BinaryMod.GetUintFromFloatBits((float)a);
            uint uux = ux & 0x7FFFF000u;
            uint h = (BinaryMod.GetUintFromFloatBits(System.Math.Min(BinaryMod.GetFloatFromUintBits(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;
            h = (int)uux >= infinity_32 ? ((int)uux > infinity_32 ? 0x7e00u : 0x7c00u) : h;
            BitsValues = (ushort)(h | (ux & ~0x7FFFF000u) >> 16);
        }
		public half(float x)
        {
            const int infinity_32 = 255 << 23;
            uint ux = BinaryMod.GetUintFromFloatBits(x);
            uint uux = ux & 0x7FFFF000u;
            uint h = (BinaryMod.GetUintFromFloatBits(System.Math.Min(BinaryMod.GetFloatFromUintBits(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;
            h = (int)uux >= infinity_32 ? ((int)uux > infinity_32 ? 0x7e00u : 0x7c00u) : h;
            BitsValues = (ushort)(h | (ux & ~0x7FFFF000u) >> 16);
        }
        [XmlIgnore]
        public static half Zero = new half();
        [XmlIgnore]
        public float ActualValue { get => this; set => this = (half)value; }
        [XmlIgnore]
        public static float MaxValue { get => 65504.0f; }
        [XmlIgnore]
        public static float MinValue { get => -65504.0f; }
        public bool Equals(half other) => BitsValues == other.BitsValues;
        public override bool Equals(object o) => Equals((half)o);
        public override string ToString() => ((float)this).ToString();
        public override int GetHashCode() => BitsValues;
        public string ToString(string format, IFormatProvider formatProvider) => ((float)this).ToString(format, formatProvider);
        public static half GetFromBits(int bits) => new half
        {
            BitsValues = (ushort)bits
        };
        public static implicit operator float(half a)
        {
            uint uf = ((uint)a.BitsValues & 0x7fff) << 0xd;
            uint e = uf & 0xf800000;
            uf += 0x38000000 + (e == 0xf800000 ? 0x38000000 : 0x0u);
            uf = (e == 0 ? BinaryMod.GetUintFromFloatBits(BinaryMod.GetFloatFromUintBits(uf + 0x800000) - 6.10351563e-05f) : uf) | ((uint)a.BitsValues & 0x8000) << 0x10;
            return BinaryMod.GetFloatFromUintBits(uf);
        }
        public static implicit operator double(half a)
        {
            uint uf = ((uint)a.BitsValues & 0x7fff) << 0xd;
            uint e = uf & 0xf800000;
            uf += 0x38000000 + (e == 0xf800000 ? 0x38000000 : 0x0u);
            uf = (e == 0 ? BinaryMod.GetUintFromFloatBits(BinaryMod.GetFloatFromUintBits(uf + 0x800000) - 6.10351563e-05f) : uf) | ((uint)a.BitsValues & 0x8000) << 0x10;
            return BinaryMod.GetFloatFromUintBits(uf);
        }
        public static explicit operator half(float a)
        {
            uint ux = BinaryMod.GetUintFromFloatBits(a);
            uint uux = ux & 0x7ffff000u;
            half b;
            b.BitsValues = (ushort)(((int)uux >= 0x7f800000 ? ((int)uux > 0x7f800000 ? 0x7e00u : 0x7c00u) : ((BinaryMod.GetUintFromFloatBits(System.Math.Min(BinaryMod.GetFloatFromUintBits(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 0xd)) | (ux & ~0x7ffff000u) >> 0x10);
            return b;
        }
        public static explicit operator half(double a)
        {
            uint ux = BinaryMod.GetUintFromFloatBits((float)a);
            uint uux = ux & 0x7ffff000u;
            half b;
            b.BitsValues = (ushort)(((int)uux >= 0x7f800000 ? ((int)uux > 0x7f800000 ? 0x7e00u : 0x7c00u) : ((BinaryMod.GetUintFromFloatBits(System.Math.Min(BinaryMod.GetFloatFromUintBits(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 0xd)) | (ux & ~0x7ffff000u) >> 0x10);
            return b;
        }
        public static implicit operator ulong(half a) => (ulong)(float)a;
        public static explicit operator half(ulong a) => (half)(float)a;
        public static implicit operator long(half a) => (long)(float)a;
        public static explicit operator half(long a) => (half)(float)a;
        public static implicit operator uint(half a) => (uint)(float)a;
        public static explicit operator half(uint a) => (half)(float)a;
        public static implicit operator int(half a) => (int)(float)a;
        public static explicit operator half(int a) => (half)(float)a;
        public static implicit operator ushort(half a) => (ushort)(float)a;
        public static implicit operator half(ushort a) => (half)(float)a;
        public static implicit operator short(half a) => (short)(float)a;
        public static implicit operator half(short a) => (half)(float)a;
        public static explicit operator byte(half a) => (byte)(float)a;
        public static implicit operator half(byte a) => (half)(float)a;
        public static explicit operator sbyte(half a) => (sbyte)(float)a;
        public static implicit operator half(sbyte a) => (half)(float)a;
        public static bool operator ==(half a, half b) => a == (float)b;
        public static bool operator !=(half a, half b) => a != (float)b;
        public static bool operator >(half a, half b) => a > (float)b;
        public static bool operator <(half a, half b) => a < (float)b;
        public static bool operator >=(half a, half b) => a >= (float)b;
        public static bool operator <=(half a, half b) => a <= (float)b;
        public static half operator +(half a, half b) => (half)(a + (float)b);
        public static half operator -(half a, half b) => (half)(a - (float)b);
        public static half operator *(half a, half b) => (half)(a * (float)b);
        public static half operator /(half a, half b) => (half)(a / (float)b);
        public static half operator %(half a, half b) => (half)(a % (float)b);
        public static float operator +(float a, half b) => a + (float)b;
        public static float operator +(half a, float b) => (float)a + b;
        public static float operator -(float a, half b) => a - (float)b;
        public static float operator -(half a, float b) => (float)a - b;
        public static float operator *(float a, half b) => a * (float)b;
        public static float operator *(half a, float b) => (float)a * b;
        public static float operator /(float a, half b) => a / (float)b;
        public static float operator /(half a, float b) => (float)a / b;
        public static float operator %(float a, half b) => a % (float)b;
        public static float operator %(half a, float b) => (float)a % b;
    }
}
