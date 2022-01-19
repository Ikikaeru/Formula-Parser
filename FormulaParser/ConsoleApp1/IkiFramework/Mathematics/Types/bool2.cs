using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public struct bool2 : IEquatable<bool2>
    {
        /// <summary>
        /// X of the bool vector.
        /// </summary>
        public bool x;
        /// <summary>
        /// Y of the bool vector3
        /// </summary>
        public bool y;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public bool u
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        [XmlIgnore]
        public bool v
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        [XmlIgnore]
        public bool2 xx
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 uu
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 xy
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public bool2 uv
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public bool2 yx
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public bool2 vu
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public bool2 yy
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 vv
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 uuu
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxy
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 uuv
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xyx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 uvu
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xyy
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 uvv
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yxx
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 vuu
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yxy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 vuv
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yyx
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 vvu
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yyy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 vvv
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uuuu
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uuuv
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uuvu
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uuvv
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uvuu
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uvuv
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uvvu
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 uvvv
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vuuu
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vuuv
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vuvu
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vuvv
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vvuu
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vvuv
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vvvu
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 vvvv
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid bool2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid bool2 index!");
                }
            }
        }
        /// <summary>
        /// Construct a vector2bool, all value are false by default.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public bool2(bool x = false, bool y = false)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Return true if one or both of the value are true.
        /// </summary>
        /// <returns></returns>
        public bool IsAnyTrue()
        {
            return x || y;
        }
        /// <summary>
        /// Return true if both value are true.
        /// </summary>
        /// <returns></returns>
        public bool IsTrue()
        {
            return x && y;
        }
        /// <summary>
        /// Return true only if one of the two value is true.
        /// </summary>
        /// <returns></returns>
        public bool IsOnlyOneTrue()
        {
            return x ^ y;
        }
        /// <summary>
        /// Negation operator for vector.
        /// </summary>
        public static bool2 operator !(bool2 a)
        {
            a.x = !a.x;
            a.y = !a.y;
            return a;
        }
        /// <summary>
        /// AND operator for vector.
        /// </summary>
        public static bool2 operator &(bool2 a, bool2 b)
        {
            a.x = a.x && b.x;
            a.y = a.y && b.y;
            return a;
        }
        /// <summary>
        /// OR operator for vector.
        /// </summary>
        public static bool2 operator |(bool2 a, bool2 b)
        {
            a.x = a.x || b.x;
            a.y = a.y || b.y;
            return a;
        }
        /// <summary>
        /// XOR operator for vector.
        /// </summary>
        public static bool2 operator ^(bool2 a, bool2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        /// <summary>
        /// Equal operator for vector.
        /// </summary>
        public static bool2 operator ==(bool2 a, bool2 b)
        {
            a.x = a.x == b.x;
            a.y = a.y == b.y;
            return a;
        }
        /// <summary>
        /// Not equal operator for vector.
        /// </summary>
        public static bool2 operator !=(bool2 a, bool2 b)
        {
            a.x = a.x != b.x;
            a.y = a.y != b.y;
            return a;
        }
        public static implicit operator bool3(bool2 v)
        {
            bool3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = false;
            return vec;
        }
        public static implicit operator uint3(bool2 v)
        {
            uint3 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = 0u;
            return vec;
        }
        public static implicit operator uint4(bool2 v)
        {
            uint4 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = 0u;
            vec.w = 0u;
            return vec;
        }
        public static implicit operator float2(bool2 v)
        {
            float2 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            return vec;
        }
        public static implicit operator int3(bool2 v)
        {
            int3 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = 0;
            return vec;
        }
        public static implicit operator int4(bool2 v)
        {
            int4 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = 0;
            vec.w = 0;
            return vec;
        }
        public static implicit operator float4(bool2 v)
        {
            float4 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = 0f;
            vec.w = 0f;
            return vec;
        }
        public static implicit operator float3(bool2 v)
        {
            float3 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = 0f;
            return vec;
        }
        public static implicit operator double4(bool2 v)
        {
            double4 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = 0d;
            vec.w = 0d;
            return vec;
        }

        public static implicit operator double3(bool2 v)
        {
            double3 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = 0d;
            return vec;
        }
        public static implicit operator bool4(bool2 v)
        {
            bool4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = false;
            vec.w = false;
            return vec;
        }
        public static implicit operator double2(bool2 v)
        {
            double2 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            return vec;
        }
        public override string ToString()
        {
            return x.ToString() + "," + y.ToString();
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2);
        }
        public override bool Equals(object other)
        {
            if (!(other is bool2))
            {
                return false;
            }
            return Equals((bool2)other);
        }
        public bool Equals(bool2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }
    }
}
